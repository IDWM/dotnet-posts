using dotnet_images.Src.DTOs;

namespace dotnet_images.Src.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<PostDto>> GetPostsAsync();
        Task CreatePostAsync(CreatePostDto createPostDto);
    }
}
