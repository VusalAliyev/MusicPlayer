using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.DTOs.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AlbumManager : IAlbumService
    {
        ISongRepository
        public Task Add(AlbumCreateDTO album)
        {
            throw new NotImplementedException();
        }

        public Task Delete(AlbumDeleteDTO album)
        {
            throw new NotImplementedException();
        }

        public Task Find(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetAll(AlbumGetDTO album)
        {
            throw new NotImplementedException();
        }

        public Task Update(AlbumUpdateDTO album)
        {
            throw new NotImplementedException();
        }
    }
}
