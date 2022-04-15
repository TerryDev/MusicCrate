namespace BlazorServerTest.Data
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Artist> Artists { get; set; }

    }
}
