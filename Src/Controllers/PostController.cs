using dotnet_posts.Src.DTOs;
using dotnet_posts.Src.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_posts.Src.Controllers
{
    public class PostController(IPostRepository postRepository) : BaseApiController
    {
        private readonly IPostRepository _postRepository = postRepository;

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _postRepository.GetPostsAsync();
            return Ok(posts);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(CreatePostDto createPostDto)
        {
            throw new NotImplementedException();
        }
    }
}
