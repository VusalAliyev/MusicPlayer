using EntityLayer.DTOs.Playlist;

namespace BusinessLayer.Abstract
{
    public interface IPlaylistService
    {
        //Task Add();
        Task<IEnumerable<PlaylistGetDTO>> GetAll();
        //Task Update();
        //Task Delete();
        //Task Find(int id);
    }
}
