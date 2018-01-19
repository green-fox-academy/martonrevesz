using Reddit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class PostRepository
    {
        public PostRepository(PostContext postContext)
        {
            PostContext = postContext;
        }

        public PostContext PostContext { get; set; }
    }
}
