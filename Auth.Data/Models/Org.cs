namespace Auth.Data.Models
{
    public class Org
    {
        public Org() { }
        public Org(string name) 
        {
            Name = name;
            Sites = new List<Site>();   
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Site> Sites { get; set; }
    }
}
