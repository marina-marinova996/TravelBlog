using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBlog.Data.Models
{
    public class PostCategory
    {
        public int Id { get; set; }

        public int PostId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
