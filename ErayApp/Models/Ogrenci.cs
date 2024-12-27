using ErayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ogrenci
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Numara { get; set; }

    // foregein key
    public int SinifId { get; set; }

    // navigate key
    public Sinif Sinif { get; set; }

    public ICollection<OgrenciDers> OgrenciDersler { get; set; }

    public override string ToString()
    {
        return $"Ad: {Ad} - Soyad: {Soyad} - Numara: {Numara} - Sınıf: {Sinif?.Ad}";
    }
}
