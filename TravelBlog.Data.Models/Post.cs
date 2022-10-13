using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TravelBlog.Common.GlobalConstants.Post;

namespace TravelBlog.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set;}

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<PostCategory> Categories { get; set; }
    }
}
