using dotnet_posts.Src.DTOs;
using dotnet_posts.Src.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_posts.Src.Controllers
{
    public class PostController(IPostRepository postRepository, IPhotoService photoService)
        : BaseApiController
    {
        private readonly IPostRepository _postRepository = postRepository;
        private readonly IPhotoService _photoService = photoService;

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _postRepository.GetPostsAsync();
            return Ok(posts);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePost(CreatePostDto createPostDto)
        {
            var result = await _photoService.AddPhotoAsync(createPostDto.Image);

            if (result.Error != null)
            {
                return BadRequest(result.Error.Message);
            }

            await _postRepository.CreatePostAsync(
                createPostDto,
                result.SecureUrl.AbsoluteUri,
                result.PublicId
            );

            return Ok();
        }
    }
}
