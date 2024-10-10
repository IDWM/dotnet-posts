using CloudinaryDotNet.Actions;

namespace dotnet_posts.Src.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
    }
}
