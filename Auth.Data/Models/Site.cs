﻿namespace Auth.Data.Models
{
    public class Site
    {
        public Site()
        {
            this.Roles = new HashSet<Role>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Org Org { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
