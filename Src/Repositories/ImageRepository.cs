using dotnet_images.Src.DTOs;
using dotnet_images.Src.Interfaces;

namespace dotnet_images.Src.Repositories
{
    public class ImageRepository : IImageRepository
    {
        public Task CreateImageAsync(CreateImageDto createImageDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ImageDto>> GetImagesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
