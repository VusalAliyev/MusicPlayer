using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Base;
using DataAccessLayer.DataContext;
using EntityLayer.Entities;

namespace DataAccessLayer.Concrete
{
    public class PlaylistRepository : RepositoryBase<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(AppDbContext context) : base(context) { }
    }
}
