using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErayApp.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}
