using AgregatorLinkowProc.DAL.Interfaces;
using AgregatorLinkowProc.Helpers;
using AgregatorLinkowProc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgregatorLinkowProc.ViewModels;

namespace AgregatorLinkowProc.Services
{
    public class UserService
    {
        private IUnitOfWork unitOfWork = null;

        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool AddNewUser(User user)
        {
            var obj = unitOfWork.UserRepository.GetWhere(x => x.Email == user.Email).FirstOrDefault();
            if (obj == null)
            {
                this.unitOfWork.UserRepository.Insert(user);
                unitOfWork.Save();
                return true;
            }
            else
                return false;
        }

        public User TryToSignIn(LoginVM model)
        {
            var user = unitOfWork.UserRepository.GetWhere(x => x.Email == model.Email).FirstOrDefault();
            if (user != null)
            {
                if (Crypto.VerifyHashedPassword(user.Password, model.Password))
                    return user;
            }

            return null;
        }

        public User GetById(Guid userId)
        {
            return this.unitOfWork.UserRepository.GetByID(userId);
        }

        public string GetUsersEmail(Guid userId)
        {
            return this.unitOfWork.UserRepository.GetByID(userId).Email;
        }
    }
}
