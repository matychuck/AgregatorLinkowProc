using AgregatorLinkowProc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Post> PostRepository { get; }
        IGenericRepository<Like> LikeRepository { get; }
        void Save();
    }
}
