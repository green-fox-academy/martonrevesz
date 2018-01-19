using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Controlles
{
    [Route("posts")]
    public class PostController : Controller
    {
        public PostController(PostService postService)
        {
            PostService = postService;
        }

        public PostService PostService { get; set; }

        public IActionResult Index()
        {
            return View(PostService.GetPosts());
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddPost(Post post)
        {
            PostService.CreatePost(post);
            return RedirectToAction("index");
        }

        [HttpGet("up")]
        public IActionResult Up(long id)
        {
            PostService.Up(id);
            return RedirectToAction("index");
        }

        [HttpGet("down")]
        public IActionResult Down(long id)
        {
            PostService.Down(id);
            return RedirectToAction("index");
        }
    }

}
