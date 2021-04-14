using AgregatorLinkowProc.DAL.Interfaces;
using AgregatorLinkowProc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ApplicationDbContext context;
        public IGenericRepository<User> UserRepository { get; }
        public IGenericRepository<Post> PostRepository { get; }
        public IGenericRepository<Like> LikeRepository { get; }

        public UnitOfWork(IGenericRepository<User> UserRepository, IGenericRepository<Post> PostRepository, IGenericRepository<Like> LikeRepository,
            ApplicationDbContext context)
        {
            this.UserRepository = UserRepository;
            this.PostRepository = PostRepository;
            this.LikeRepository = LikeRepository;
            this.context = context;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;



        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
