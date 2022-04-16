namespace BlazorServerTest.Data
{
    public enum UserCollectionType
    {
        Albums = 1,
        Tracks = 2
    }
    public class UserCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ApplicationUser Creator { get; set; }
        public UserCollectionType Type { get; set; }

    }
}
