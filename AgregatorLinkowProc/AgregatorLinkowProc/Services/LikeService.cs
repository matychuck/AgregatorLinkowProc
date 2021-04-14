using AgregatorLinkowProc.DAL.Interfaces;
using AgregatorLinkowProc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Services
{
    public class LikeService
    {
        private IUnitOfWork unitOfWork = null;

        public LikeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int CountPostsLikes(Guid postId)
        {
            return this.unitOfWork.LikeRepository.GetWhere(x => x.PostId == postId).Count();
        }

        public void LikePost(Guid postId, Guid userId)
        {

            Like like = new Like(postId, userId);
            if(!CheckIfThatLikeExists(userId, postId))
            {
                this.unitOfWork.LikeRepository.Insert(like);
                this.unitOfWork.Save();
            }
                
        }

        public void DislikePost(Guid postId, Guid userId)
        {
            var like = GetLike(userId, postId);
            if (like != null)
            {
                this.unitOfWork.LikeRepository.Delete(like);
                this.unitOfWork.Save();
            }         
        }

        public void ChangeLike(Guid postId, Guid userId, bool likeStatus)
        {
            if (likeStatus)
                LikePost(postId, userId);
            else
                DislikePost(postId, userId);
        }

        public bool CheckIfThatLikeExists(Guid userId, Guid postId)
        {
            return this.unitOfWork.LikeRepository.GetWhere(x => x.UserId == userId && x.PostId == postId).Any(); ;
        }

        private Like GetLike(Guid userId, Guid postId)
        {
            return this.unitOfWork.LikeRepository.GetWhere(x => x.UserId == userId && x.PostId == postId).FirstOrDefault();
        }
    }
}
