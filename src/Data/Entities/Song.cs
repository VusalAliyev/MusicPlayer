using Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Song:BaseAuditableEntity
    {
        public string Name { get; set; }
        public Artist Artist { get; set; }
    }
    class Artist : BaseAuditableEntity
    {
        public string Name { get; set; }
    }
}
