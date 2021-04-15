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

        /// <summary>
        /// Zliczanie polubień posta o danym id
        /// </summary>
        /// <param name="postId">Identyfikator sprawdzanego posta</param>
        /// <returns></returns>
        public int CountPostsLikes(Guid postId)
        {
            return this.unitOfWork.LikeRepository.GetWhere(x => x.PostId == postId).Count();
        }

        /// <summary>
        /// Polubienie posta
        /// </summary>
        /// <param name="postId">Identyfikator polubianego posta</param>
        /// <param name="userId">Identyfikator użytkownika, który polubia post</param>
        public void LikePost(Guid postId, Guid userId)
        {

            Like like = new Like(postId, userId);
            if(!CheckIfThatLikeExists(userId, postId))
            {
                this.unitOfWork.LikeRepository.Insert(like);
                this.unitOfWork.Save();
            }
                
        }

        /// <summary>
        /// Odpolubienie posta
        /// </summary>
        /// <param name="postId">Identyfikator posta</param>
        /// <param name="userId">Identyfikator użytkownika, który cofa polubienie post</param>
        public void DislikePost(Guid postId, Guid userId)
        {
            var like = GetLike(userId, postId);
            if (like != null)
            {
                this.unitOfWork.LikeRepository.Delete(like);
                this.unitOfWork.Save();
            }         
        }

        /// <summary>
        /// Polubienie lub cofnięcie polubienia w zależności od parametru likeStatus
        /// </summary>
        /// <param name="postId">Identyfikator posta</param>
        /// <param name="userId">Identyfikator użytkownika</param>
        /// <param name="likeStatus">Nowa wartość polubienia. Jeśli True: dodaje polubienie; False: cofa polubienie</param>
        public void ChangeLike(Guid postId, Guid userId, bool likeStatus)
        {
            if (likeStatus)
                LikePost(postId, userId);
            else
                DislikePost(postId, userId);
        }

        /// <summary>
        /// Sprawdzenie czy użytkownik polubił dany post
        /// </summary>
        /// <param name="userId">Identyfikator użytkownika</param>
        /// <param name="postId">Identyfikator posta</param>
        /// <returns></returns>
        public bool CheckIfThatLikeExists(Guid userId, Guid postId)
        {
            return this.unitOfWork.LikeRepository.GetWhere(x => x.UserId == userId && x.PostId == postId).Any(); ;
        }

        //Pobieranie polubienia, jeśli istnieje
        private Like GetLike(Guid userId, Guid postId)
        {
            return this.unitOfWork.LikeRepository.GetWhere(x => x.UserId == userId && x.PostId == postId).FirstOrDefault();
        }
    }
}
