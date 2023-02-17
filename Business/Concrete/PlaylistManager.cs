using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.DTOs.Playlist;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class PlaylistManager : IPlaylistService
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IMapper _mapper;

        public PlaylistManager(IPlaylistRepository playlistRepository, IMapper mapper)
        {
            _playlistRepository = playlistRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PlaylistGetDTO>> GetAll()
        {
            IEnumerable<Playlist> playlists = await _playlistRepository.GetAll();
            var result = _mapper.Map<IEnumerable<PlaylistGetDTO>>(playlists);
            return result;
        }
    }
}
