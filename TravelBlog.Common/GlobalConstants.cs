using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBlog.Common
{
    public class GlobalConstants
    {
        public static class Post
        {
            public const int TitleMaxLength = 50;
            public const int ContentMaxLength = 1500;
        }

        public static class Category
        {
            public const int NameMaxLength = 50;
        }

       public static class Role
        {
            public const string Administrator = "Administrator";
        }
    }
}
