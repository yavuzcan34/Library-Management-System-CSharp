using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_hazırlık
{
    public class Kitap
    {
        public static List<Kitap> KitapListesi = new List<Kitap>();
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }
        public string Yayinevi { get; set; }
        public string Yil { get; set; }
        public string Kategori { get; set; }
        public string Durum { get; set; }
    }
}
