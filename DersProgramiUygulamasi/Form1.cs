using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersProgramiUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void EkraniHazirla()
        {
            txtDersKodu.Text = txtDersAdi.Text = txtDersHocasi.Text = txtDersBaslamaSaati.Text = txtDersBitisSaati.Text = "";
            
            txtDersKodu.Focus();
        }
            
            
            DersProgrami dersProgrami = new DersProgrami();
         
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            Dersler ders = new Dersler();
            int dersKodu = Convert.ToInt32(txtDersKodu.Text);

            
            ders.dersOzellik = new DersOzellik(dersKodu);
            ders.dersOzellik.DersAdi = txtDersAdi.Text;
            ders.dersOzellik.DersHocasi = txtDersHocasi.Text;
            ders.BaslamaSaati = Convert.ToDateTime(txtDersBaslamaSaati.Text);
            ders.BitisSaati = Convert.ToDateTime(txtDersBitisSaati.Text);
            bool uyari = ders.Uyari();
            if (uyari==true)
            {
                dersProgrami.DersEkle(ders);
                
            }
            
            
            EkraniHazirla();
         

        }

        private void btnDersleriListele_Click(object sender, EventArgs e)
        {
         txtListele.Text=dersProgrami.DersListele();
        }
    }
}
