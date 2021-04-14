using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Models
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid PostId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100, ErrorMessage = "Maxiumum length is 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Link is required")]
        public string Link { get; set; }

        public virtual User User { get; set; }

        public Guid UserId { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
