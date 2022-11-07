using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikVeStaticClass
{
    internal class Ogrenci
    {
        public int Id { get; set; }
        public string ?Ad { get; set; }
        public string SoyAd { get; set; }
        string FullName()
        {
            return Ad + SoyAd;
        }
    }
}
