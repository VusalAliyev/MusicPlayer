using AutoMapper;
using EntityLayer.DTOs.Album;
using EntityLayer.DTOs.Playlist;
using EntityLayer.Entities;

namespace BusinessLayer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Album, AlbumCreateDTO>().ReverseMap();
            CreateMap<Album, AlbumUpdateDTO>().ReverseMap();
            CreateMap<Album, AlbumGetDTO>().ReverseMap();
            CreateMap<Album, AlbumDeleteDTO>().ReverseMap();

            CreateMap<Playlist, PlaylistGetDTO>().ReverseMap();
        }
    }
}
