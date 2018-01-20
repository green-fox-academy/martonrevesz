using Reddit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Models;

namespace Reddit.Repositories
{
    public class PostRepository
    {
        public PostRepository(PostContext postContext)
        {
            PostContext = postContext;
        }

        public PostContext PostContext { get; set; }

        public List<Post> GetPosts()
        {
            return PostContext.Posts.ToList();
        }

        public void CreatePost(Post post)
        {
            PostContext.Posts.Add(post);
            PostContext.SaveChanges();
        }

        public void Up(long id)
        {
            PostContext.Posts.FirstOrDefault(x => x.PostId == id).Score++;
            PostContext.SaveChanges();
        }

        public List<Post> GetTenPosts(int i)
        {
            var listAll = GetPosts();
            var resultList = new List<Post>();
            var sortedList = listAll.OrderByDescending(x => x.Score).ToList();
            for (int j = 10 * i ; j < Math.Min(sortedList.Count, 10 * i + 10) ; j++)
            {
                resultList.Add(sortedList[j]);
            }
            resultList.AddRange(sortedList
                .Where(x => (10 * i  > sortedList.IndexOf(x)) || (sortedList.IndexOf(x) >= Math.Min(sortedList.Count, 10 * i + 10))));
            return resultList;
        }

        public void Down(long id)
        {
            PostContext.Posts.FirstOrDefault(x => x.PostId == id).Score--;
            PostContext.SaveChanges();
        }
    }
}
