using AutoMapper;
using EntityLayer.DTOs.Album;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Album, AlbumCreateDTO>().ReverseMap();
            CreateMap<Album, AlbumUpdateDTO>().ReverseMap();
            CreateMap<Album, AlbumGetDTO>().ReverseMap();
            CreateMap<Album, AlbumDeleteDTO>().ReverseMap();
        }
    }
}
