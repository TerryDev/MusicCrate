namespace BlazorServerTest.Data
{
    public class Review
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int Stars { get; set; }
        public DateTime PostTime { get; set; }
        public ApplicationUser User { get; set; }
        public int AlbumId { get; set; }
        public int Likes { get; }
    }
}
