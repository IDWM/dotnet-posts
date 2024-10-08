using dotnet_images.Src.DTOs;
using dotnet_images.Src.Interfaces;

namespace dotnet_images.Src.Repositories
{
    public class PostRepository : IPostRepository
    {
        public Task CreatePostAsync(CreatePostDto createPostDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostDto>> GetPostsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
