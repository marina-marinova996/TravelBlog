using System.ComponentModel.DataAnnotations;
using static TravelBlog.Common.GlobalConstants.Category;

namespace TravelBlog.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]  
        public string Name { get; set; }

        public ICollection<PostCategory> Posts { get; set; }
    }
}
