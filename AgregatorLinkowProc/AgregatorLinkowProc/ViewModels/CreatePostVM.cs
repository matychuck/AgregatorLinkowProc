using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.ViewModels
{
    public class CreatePostVM
    {
        public PostVM post { get; set; }
        public IEnumerable<PostVM> posts { get; set; }
    }
}
