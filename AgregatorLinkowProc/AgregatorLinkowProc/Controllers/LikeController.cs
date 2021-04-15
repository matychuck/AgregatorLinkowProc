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

        /// <summary>
        /// Zmiana polubienia postu
        /// </summary>
        /// <param name="postId">Identyfikato postu</param>
        /// <param name="newStatus">Nowy stan polubienia</param>
        /// <returns></returns>
        [LoggedUser]
        public async Task<IActionResult> ChangeLike(string postId, bool newStatus)
        {
            var currentUserId = HttpContext.Session.GetString("UserId");
            if (!_postService.isUserPostAuthor(Guid.Parse(currentUserId), Guid.Parse(postId))) //jeśli obecny użytkownik nie jest autorem posta
                await Task.Run(() => _likeService.ChangeLike(Guid.Parse(postId), Guid.Parse(currentUserId), newStatus)); //dodanie lub cofnięcie polubienia
            return RedirectToAction("Index", "Home");
        }
    }
}
