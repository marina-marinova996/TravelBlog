using TravelBlog.Data;
using TravelBlog.Data.Models;
using TravelBlog.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using TravelBlog.Controllers;

namespace ForumApp.Web.Controllers
{
    public class PostController : BaseController
    {
        private readonly ApplicationDbContext context;

        public PostController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var posts = await this.context
                            .Posts
                            .Select(p => new PostViewModel()
                            {
                                Id = p.Id,
                                Title = p.Title,
                                Content = p.Content,
                                ImageUrl = p.ImageUrl,
                            })
                            .ToListAsync();

            return View(posts);
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var posts = await this.context
                            .Posts
                            .Select(p => new PostViewModel()
                            {
                                Id = p.Id,
                                Title = p.Title,
                                Content = p.Content,
                                ImageUrl = p.ImageUrl,
                            })
                            .ToListAsync();
                            
            return View(posts);
        }

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]

        public async Task<IActionResult> Add(PostFormViewModel model)
        {
            var post = new Post()
            {
               Title = model.Title,
               Content = model.Content
            };

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var post = await this.context.Posts.FindAsync(id);

            return View(new PostFormViewModel()
            {
                Title = post.Title,
                Content = post.Content,
            });
        }

        [HttpPost]

        public async Task<IActionResult> Edit (int id, PostFormViewModel model)
        {
            var post = await this.context.Posts.FindAsync(id);
            post.Title = model.Title;
            post.Content = model.Content;

            await this.context.SaveChangesAsync();

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var post = await this.context.Posts.FindAsync(id);

            this.context.Remove(post);
            await this.context.SaveChangesAsync();

            return RedirectToAction("All");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, PostFormViewModel model)
        {
            var post = await this.context.Posts.FindAsync(id);
            post.Title = model.Title;
            post.Content = model.Content;

            await this.context.SaveChangesAsync();

            return RedirectToAction("All");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var post = await this.context.Posts.FindAsync(id);

            return View(new PostViewModel()
            {
                Title = post.Title,
                Content = post.Content,
                ImageUrl = post.ImageUrl,
            });
        }
    }
}
