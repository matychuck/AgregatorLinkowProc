using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Models
{
    public class Like
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid LikeId { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }

        public Like() { }
        public Like(Guid postId, Guid userId)
        {
            this.UserId = userId;
            this.PostId = postId;
        }
    }
}
