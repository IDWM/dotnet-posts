using dotnet_posts.Src.DTOs;

namespace dotnet_posts.Src.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<PostDto>> GetPostsAsync();
        Task CreatePostAsync(CreatePostDto createPostDto);
    }
}
