using AgregatorLinkowProc.DAL.Interfaces;
using AgregatorLinkowProc.Models;
using AgregatorLinkowProc.Services;
using AgregatorLinkowProc.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace AgregatorLinkowProc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserService _userService;
        private readonly PostService _postService;
        private readonly LikeService _likeService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, UserService userService, PostService postService, LikeService likeService)
        {
            _logger = logger;
            this._userService = userService;
            this.unitOfWork = unitOfWork;
            this._postService = postService;
            this._likeService = likeService;
        }

        public IActionResult Index(int? page)
        {         
            var pageNumber = page ?? 1; 
            int pageSize = 100; 
            var currentUserId = HttpContext.Session.GetString("UserId");
            var posts = _postService.GetNotExpiredPosts();
            IEnumerable<PostVM> model = null;
            if (posts != null)
            {
                model = posts.Select(x => new PostVM()
                {
                    isLikedByUser = currentUserId == null ? false : _likeService.CheckIfThatLikeExists(Guid.Parse(currentUserId),x.PostId),
                    PostId = x.PostId,
                    Title = x.Title,
                    Link = x.Link,
                    AuthorId = x.UserId,
                    AuthorLogin = _userService.GetUsersEmail(x.UserId),
                    Date = x.Date,
                    Likes = _likeService.CountPostsLikes(x.PostId)
                }).OrderByDescending(x => x.Likes).ToPagedList(pageNumber, pageSize); 
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
