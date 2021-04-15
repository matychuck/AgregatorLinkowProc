using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.ViewModels
{
    public class PostVM
    {
        public Guid PostId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100, ErrorMessage = "Maxiumum length is 100 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Link is required")]
        public string Link { get; set; }
        public Guid AuthorId { get; set; }
        public string AuthorLogin { get; set; }

        public int Likes { get; set; }

        public DateTime Date { get; set; } //data stworzenia posta

        public bool isLikedByUser { get; set; } //sprawdzenie czy post jest polubiony przez obecnie zalogowanego użytkownika

        public bool isUserAuthor { get; set; } //sprawdzenie czy obecnie zalogowany użytkownik jest autorem posta
    }
}
