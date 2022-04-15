using BlazorServerTest.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.Controllers
{
    public class AlbumController
    {
        private readonly ApplicationDbContext _context;

        public AlbumController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Album>> GetAlbums()
        {
            var result = await _context.Albums.AsQueryable().ToListAsync();


            return result;
        }
    }
}
