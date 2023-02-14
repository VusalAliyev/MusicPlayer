using EntityLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Artist:BaseEntity
    {
        public string FullName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
