namespace BlazorServerTest.Data
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
        public List<Track> Tracks { get; set; }

    }
}
