using System.Collections.Generic;

namespace Reddit.Models
{
    public class User
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}