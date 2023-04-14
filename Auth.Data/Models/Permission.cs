﻿namespace Auth.Data.Models
{
    public class Permission
    {
        public Permission()
        {
            this.Roles = new HashSet<Role>();
        }
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
