using System;

namespace BlogApp.Entity.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Body { get; set; }

        public DateTime AddedDateTime { get; set; }

        public bool IsApproved { get; set; }

        public string? Image { get; set; }
    }
}