namespace BlazorServerTest.Data
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Album Album { get; set; }
        public List<Artist> Artists { get; set; }
        public int RunningTime { get; set; }

    }
}
