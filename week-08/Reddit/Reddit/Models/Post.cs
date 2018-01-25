using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        public long? PostId { get; set; }
        public int Score { get; set; }
        public string Content { get; set; }
        public string CreatonTime { get; set; } = DateTime.Now.ToString("dd/MMM/yy");
        public long UserId { get; set; }
        public User User { get; set; }

    }
}
