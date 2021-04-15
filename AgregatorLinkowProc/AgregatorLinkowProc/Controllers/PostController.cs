using AgregatorLinkowProc.Filters;
using AgregatorLinkowProc.Models;
using AgregatorLinkowProc.Services;
using AgregatorLinkowProc.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace AgregatorLinkowProc.Controllers
{
    public class PostController : Controller
    {
        private readonly PostService _postService;
        private readonly LikeService _likeService;
        private readonly UserService _userService;

        public PostController(PostService postService, LikeService likeService, UserService userService)
        {
            this._postService = postService;
            this._likeService = likeService;
            this._userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Tworzenie posta z listą postów użytkownika
        [LoggedUser]
        public async Task<IActionResult> CreatePost(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 100;
            var currentUserId = HttpContext.Session.GetString("UserId");
            CreatePostVM model = new CreatePostVM();
            if (currentUserId != null)
            {

                var posts = await _postService.GetUsersPosts(Guid.Parse(currentUserId));
                if(posts != null)
                {
                    model.posts = posts.Select(x => new PostVM()
                    {
                        PostId = x.PostId,
                        Title = x.Title,
                        Link = x.Link,
                        AuthorId = x.UserId,
                        AuthorLogin = _userService.GetUsersEmail(x.UserId),
                        Date = x.Date,
                        Likes = _likeService.CountPostsLikes(x.PostId)
                    }).OrderByDescending(x => x.Likes).ToPagedList(pageNumber, pageSize); ;
                }
                else
                {
                    model.posts = null;
                }
                return View(model);
            }
            else
            {
                return View(model);
            }
        }

        [LoggedUser]
        [HttpPost]
        public IActionResult CreatePost(CreatePostVM model)
        {
            var currentUserId = HttpContext.Session.GetString("UserId");
            if (!string.IsNullOrEmpty(currentUserId))
            {
                Post post = new Post(Guid.Parse(currentUserId), model.post.Link, model.post.Title);
                if (_postService.AddPost(post))
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }
    }
}
