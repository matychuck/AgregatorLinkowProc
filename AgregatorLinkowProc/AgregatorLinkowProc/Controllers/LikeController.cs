using AgregatorLinkowProc.Filters;
using AgregatorLinkowProc.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Controllers
{
    public class LikeController : Controller
    {
        private readonly LikeService _likeService;
        private readonly PostService _postService;
        public LikeController(LikeService likeService, PostService postService)
        {
            this._likeService = likeService;
            this._postService = postService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [LoggedUser]
        public IActionResult ChangeLike(string postId, bool newStatus)
        {
            var currentUserId = HttpContext.Session.GetString("UserId");
            if(!_postService.isUserPostAuthor(Guid.Parse(currentUserId), Guid.Parse(postId)))
                _likeService.ChangeLike(Guid.Parse(postId), Guid.Parse(currentUserId), newStatus);
            return RedirectToAction("Index", "Home");
        }
    }
}
