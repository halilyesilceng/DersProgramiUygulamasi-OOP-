using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersProgramiUygulamasi
{
    public class DersProgrami
    {
        public List<Dersler> DersListesi { get; set; } = new List<Dersler>();


        public void DersEkle(Dersler d)
        {
            DersListesi.Add(d);
        }
        public void DersCikar(Dersler d)
        {
            DersListesi.Remove(d);
        }
        public string DersListele()
        {
            string liste = "";
            
            foreach (Dersler dersler in DersListesi)
            {
                liste += "Ders Kodu :" + dersler.dersOzellik.DersKodu + "Ders Adı :" + dersler.dersOzellik.DersAdi.ToString() + "Ders Hocasi :" + dersler.dersOzellik.DersHocasi + "BAŞLAMA SAATİ :" + dersler.BaslamaSaati.ToString("t") + "BİTİŞ SAATİ :" + dersler.BitisSaati.ToString("t")+Environment.NewLine;
                //Environmet.NewLine komutu sayesinde her ders eklendiğinde bi alt satıra geçer;
            }
            
            return liste;
        }
    }
}
