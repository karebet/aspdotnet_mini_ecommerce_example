using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce_mini.Shared
{
    internal class Katergori
    {
        public int KatergoriId { get; set; }
        public string KatergoriName { get; set; }
        public string KatergoriImg { get; set; }
        public string KatergoriSlug { get; set; }
        public int KatergoriStatus { get; set; }
    }
    internal class Produk
    {
        public int ProdukiId { get; set; }
        public string ProdukName { get; set; }
        public string ProdukImg { get; set; }
        public string ProdukSlug { get; set; }
        public int ProdukStatus { get; set; }
        public int ProdukHarga { get; set; }
        public int ProdukBintang { get; set; }
    }

    

}
