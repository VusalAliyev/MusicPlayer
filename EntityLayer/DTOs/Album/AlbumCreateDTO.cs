using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs.Album
{
    public class AlbumCreateDTO
    {
        public string Name { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
    }
}
