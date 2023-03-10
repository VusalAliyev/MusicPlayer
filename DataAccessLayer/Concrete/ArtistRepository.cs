using DataAccessLayer.Concrete.Base;
using DataAccessLayer.DataContext;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ArtistRepository : RepositoryBase<Artist>
    {
        public ArtistRepository(AppDbContext context) : base(context) { }
    }
}
