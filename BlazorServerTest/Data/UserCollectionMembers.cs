namespace BlazorServerTest.Data
{
    public class UserCollectionMembers
    {
        public int Id { get; set; }
        public int? AlbumId { get; set; }
        public int? TrackId { get; set; }
        public int UserCollectionId { get; set; }
        public UserCollection UserCollection { get; set; }
        public Album? Album { get; set; }
        public Track? Track { get; set; }

    }
}
