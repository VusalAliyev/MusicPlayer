using EntityLayer.DTOs.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAlbumService
    {
        Task Add(AlbumCreateDTO album);
        Task Update(AlbumUpdateDTO album);
        Task Delete(AlbumDeleteDTO album);
        Task Find(int id);
        Task GetAll(AlbumGetDTO album);

    }
}
