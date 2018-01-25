using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditClone.Services;

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
            var posts = PostService.GetAllPosts();
            return Json(posts);
        }

        [HttpPost("")]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPut("{id}/upvote")]
        public IActionResult Upvote()
        {
            return Ok();
        }

        [HttpPut("{id}/downvote")]
        public IActionResult Downvote()
        {
            return Ok();
        }
    }
}
