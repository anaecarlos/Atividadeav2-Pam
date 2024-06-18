using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeav2.Models
{
    public class photos
    {
        public string AlbumId { get; set; }
        public int id { get; set; }
        public int Id { get => id; set => id = value; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
