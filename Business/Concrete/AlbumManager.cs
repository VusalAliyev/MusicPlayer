using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.DTOs.Album;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AlbumManager : IAlbumService
    {
        IAlbumRepository _albumRepository;
        private readonly IMapper _mapper;

        public AlbumManager(IAlbumRepository albumRepository, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _mapper = mapper;
        }

        public async Task Add(AlbumCreateDTO albumCreateDTO)
        {
            var result = _mapper.Map<Album>(albumCreateDTO);
            await _albumRepository.Add(result);
        }

        public async Task Delete(AlbumDeleteDTO albumDeleteDTO)
        {
            var result = _mapper.Map<Album>(albumDeleteDTO);
            await _albumRepository.Remove(result);
        }

        public async Task Find(int id)
        {
            await _albumRepository.Find(id);
        }

        public async Task<IEnumerable<AlbumGetDTO>> GetAll()
        {
            IEnumerable<Album> albums = await _albumRepository.GetAll();
            var result = _mapper.Map<IEnumerable<AlbumGetDTO>>(albums);
            return result;
        }

        public async Task Update(AlbumUpdateDTO  albumUpdateDTO)
        {
            var result = _mapper.Map<Album>(albumUpdateDTO);
            await _albumRepository.Remove(result);  
        }
    }
}
