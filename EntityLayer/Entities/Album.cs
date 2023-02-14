using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Album:BaseEntity
    {
        public string Name { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
