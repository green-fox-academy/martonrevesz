using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditClone.Services;
using RedditClone.Models;

namespace RedditClone.Controllers
{    
    [Route("[controller]")]
    public class PostsController : Controller
    {
        public PostsController(PostService postService)
        {
            PostService = postService;
        }

        public PostService PostService { get; set; }

        [HttpGet("")]
        public IActionResult Get()
        {
            var allPosts = PostService.GetAllPosts();
            return Json(new { posts = allPosts });
        }

        [HttpPost("")]
        public IActionResult Create([FromBody] Post post)
        {
            PostService.CreatePost(post);
            return Json(PostService.GetLastPost());
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            var post = PostService.GetPost(id);
            PostService.DeletePost(id);
            return Json(post);
        }

        [HttpPut("{id}/upvote")]
        public IActionResult Upvote([FromRoute] long id)
        {
            PostService.UpvotePost(id);
            return Json(PostService.GetPost(id));
        }

        [HttpPut("{id}/downvote")]
        public IActionResult Downvote([FromRoute] long id)
        {
            PostService.DownvotePost(id);
            return Json(PostService.GetPost(id));
        }
    }
}
