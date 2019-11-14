using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramiUygulamasi
{
    public class Dersler
    {
        public DersOzellik dersOzellik { get; set; }
        public DateTime dersozellik { get; set; }
        public DateTime BaslamaSaati { get; set; }
        public DateTime BitisSaati { get; set; }
        
        public bool Uyari()
        {
            
            if (BaslamaSaati > BitisSaati)
            {
                
                return false;
            }
            else { 
            return true;
            }
        }
        

    }
}
