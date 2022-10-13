using TravelBlog.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<PostCategory> PostsCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
                .Entity<Post>()
                .HasData(new Post
                {
                    Id = 1,
                    Title = "Vihren Peak, Pirin Mountain",
                    Content = "Vihren is the highest peak of Bulgaria's Pirin Mountains. Reaching 2,914 metres, it is Bulgaria's second and the Balkans' third highest, after Musala and Mount Olympus.!",
                    ImageUrl = "/images/20220907_104644.jpg",
                },
                new Post
                {
                    Id = 2,
                    Title = "Seven Rila Lakes, Rila Mountain",
                    Content = "The Seven Rila Lakes are a group of glacial lakes, situated in the northwestern Rila Mountain in Bulgaria. They are the most visited group of lakes in Bulgaria. The lakes are situated between 2,100 and 2,500 metres elevation above sea level. Each lake carries a name associated with its most characteristic feature.",
                    ImageUrl = "/images/20210912_103641.jpg",
                },
                new Post
                {
                    Id = 3,
                    Title = "Waterfall \"Raisko Praskalo\", Balkan Mountain",
                    Content = "Raysko Praskalo, 124.5 m in height, is the highest waterfall in Bulgaria and the Balkan Peninsula. It is situated under Botev Peak in the central section of the Balkan Mountains and is part of the Dzhendema Reserve of the Central Balkan National Park. The nearest town is Kalofer, at 11 km to the south.",
                    ImageUrl = "/images/DSC01288.JPG",
                });

            builder
                .Entity<Category>()
                .HasData(new Category
                {
                    Id = 1,
                    Name = "Rila",
                },
                new Category
                {
                    Id = 2,
                    Name = "Pirin",
                },
                new Category
                {
                    Id = 3,
                    Name = "Rhodope",
                },
                new Category
                {
                    Id = 4,
                    Name = "Balkan Mountains",
                });

            base.OnModelCreating(builder);
        }

    }
}
