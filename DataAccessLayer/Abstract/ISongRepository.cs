using DataAccessLayer.Abstract.Base;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ISongRepository:IRepositoryBase<Song>
    {
    }
}
