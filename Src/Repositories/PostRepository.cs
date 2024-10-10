using dotnet_posts.Src.Data;
using dotnet_posts.Src.DTOs;
using dotnet_posts.Src.Interfaces;
using dotnet_posts.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_posts.Src.Repositories
{
    public class PostRepository(DataContext dataContext) : IPostRepository
    {
        private readonly DataContext _dataContext = dataContext;

        public async Task CreatePostAsync(CreatePostDto createPostDto, string url, string publicId)
        {
            var post = new Post
            {
                Title = createPostDto.Title,
                Description = createPostDto.Description,
                Url = url,
                PublicId = publicId
            };

            await _dataContext.Posts.AddAsync(post);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<PostDto>> GetPostsAsync()
        {
            return await _dataContext
                .Posts.Select(post => new PostDto
                {
                    Title = post.Title,
                    Description = post.Description,
                    Url = post.Url,
                    PublicId = post.PublicId
                })
                .ToArrayAsync();
        }
    }
}
