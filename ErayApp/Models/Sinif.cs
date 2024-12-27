using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErayApp.Models
{
    public class Sinif
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Kontenjan { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
