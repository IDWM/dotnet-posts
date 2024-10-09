using dotnet_posts.Src.DTOs;
using dotnet_posts.Src.Interfaces;

namespace dotnet_posts.Src.Repositories
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
