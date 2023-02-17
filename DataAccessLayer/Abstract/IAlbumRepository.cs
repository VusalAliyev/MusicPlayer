using DataAccessLayer.Abstract.Base;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace DataAccessLayer.Abstract
{
    public interface IAlbumRepository:IRepositoryBase<Album>
    {
    }
}


