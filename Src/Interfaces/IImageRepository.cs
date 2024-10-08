using dotnet_images.Src.DTOs;

namespace dotnet_images.Src.Interfaces
{
    public interface IImageRepository
    {
        Task<IEnumerable<ImageDto>> GetImagesAsync();
        Task CreateImageAsync(CreateImageDto createImageDto);
    }
}
