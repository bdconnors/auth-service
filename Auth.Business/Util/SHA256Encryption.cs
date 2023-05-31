using System.Security.Cryptography;

namespace Auth.Business.Util
{
    public static class SHA256Encryption
    {
        private static readonly HashAlgorithmName _alg = HashAlgorithmName.SHA256;
        private const int _saltSize = 16; // 128 bits
        private const int _keySize = 32; // 256 bits
        private const int _iterations = 50000;
        private const char delimiter = ':';

        public static string Hash(string value)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(_saltSize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(value, salt, _iterations, _alg, _keySize);
            string hashHex = Convert.ToHexString(hash);
            string saltHex = Convert.ToHexString(salt);

            return string.Join(delimiter, hashHex, saltHex, _iterations, _alg);
        }

        public static bool Verify(string value, string hashed)
        {
            string[] segments = hashed.Split(delimiter);

            byte[] hash = Convert.FromHexString(segments[0]);
            byte[] salt = Convert.FromHexString(segments[1]);

            int iterations = int.Parse(segments[2]);
            int hashSize = hash.Length;

            HashAlgorithmName hashAlg = new HashAlgorithmName(segments[3]);

            byte[] inputHash = Rfc2898DeriveBytes.Pbkdf2(value, salt, iterations, hashAlg, hashSize);

            return CryptographicOperations.FixedTimeEquals(inputHash, hash);
        }
    }
}
