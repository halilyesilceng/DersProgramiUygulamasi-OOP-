using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramiUygulamasi
{
    public class DersOzellik
    {
        public int DersKodu { get; private set; }
        public string DersAdi { get; set; }
        public string DersHocasi { get; set; }
        public DersOzellik(int dK)
        {
            this.DersKodu = dK;
        }
    }
}
