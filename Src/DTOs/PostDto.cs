namespace dotnet_posts.Src.DTOs
{
    public class PostDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Url { get; set; }
        public required string PublicId { get; set; }
    }
}
