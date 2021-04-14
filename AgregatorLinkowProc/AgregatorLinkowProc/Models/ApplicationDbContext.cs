using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        DbSet<User> Users { get; set; }
        DbSet<Post> Posts { get; set; }

        DbSet<Like> Likes { get; set; }

    }
}
