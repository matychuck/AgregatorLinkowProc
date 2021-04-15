using AgregatorLinkowProc.DAL.Interfaces;
using AgregatorLinkowProc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Services
{
    public class PostService
    {
        private IUnitOfWork unitOfWork = null;

        public PostService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool AddPost(Post post)
        {
            try
            {
                unitOfWork.PostRepository.Insert(post);
                unitOfWork.Save();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        //Pobieranie postów autorstwa użytkownika o przesłanym identyfikatorze
        public async Task<IEnumerable<Post>> GetUsersPosts(Guid userId)
        {
            return await Task.Run(() => this.unitOfWork.PostRepository.GetWhere(x => x.UserId == userId));
        }

        public void RemoveAll()
        {   
            var posts = this.unitOfWork.PostRepository.GetWhere();
            foreach (var post in posts)
            {
                this.unitOfWork.PostRepository.Delete(post);
                this.unitOfWork.Save();
            }          
        }

        //Pobieranie postów nie starszych niż 5 dni
        public async Task<IEnumerable<Post>> GetNotExpiredPosts()
        {
            var expireDate = DateTime.Now.AddDays(-5);
            return await Task.Run(() => this.unitOfWork.PostRepository.GetWhere(x => x.Date > expireDate));
        }

        /// <summary>
        /// Sprawdzenie czy użytkownik jest autorem posta
        /// </summary>
        /// <param name="userId">Identyfikator użytkownika</param>
        /// <param name="postId">Identyfikator posta</param>
        /// <returns></returns>
        public bool isUserPostAuthor(Guid userId, Guid postId)
        {
            var post = this.unitOfWork.PostRepository.GetByID(postId);
            if(post != null)
            {
                if (post.UserId == userId)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
