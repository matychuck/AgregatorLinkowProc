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

        public IEnumerable<Post> GetUsersPosts(Guid userId)
        {
            return this.unitOfWork.PostRepository.GetWhere(x => x.UserId == userId);
        }

        public void RemoveAll()
        {   var tmp = this.unitOfWork.PostRepository.GetWhere();
            foreach(var x in tmp)
            {
                this.unitOfWork.PostRepository.Delete(x);
                this.unitOfWork.Save();
            }          
        }

        public async Task<IEnumerable<Post>> GetNotExpiredPosts()
        {
            var expireDate = DateTime.Now.AddDays(-5);
            return await Task.Run(() => this.unitOfWork.PostRepository.GetWhere(x => x.Date > expireDate));
        }

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
