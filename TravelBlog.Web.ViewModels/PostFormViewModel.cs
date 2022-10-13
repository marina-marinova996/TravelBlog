using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBlog.Web.ViewModels
{
    public class PostFormViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 10)]

        public string Title { get; set; }

        [Required]
        [StringLength(1500, MinimumLength =30)]

        public string Content { get; set; }
    }
}
