namespace dotnet_posts.Src.DTOs
{
    public class CreatePostDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required IFormFile Image { get; set; }
    }
}
