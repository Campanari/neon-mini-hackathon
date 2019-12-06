using System;

namespace NeonHackathon.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime CommentDate { get; set; }
        public User User { get; set; }
        public Post Post { get; set;}
    }
}