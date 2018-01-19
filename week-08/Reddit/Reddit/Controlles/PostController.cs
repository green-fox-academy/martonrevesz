using Microsoft.AspNetCore.Mvc;
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
    }
}
