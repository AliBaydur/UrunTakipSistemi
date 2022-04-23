using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakipSistemi
{
    public partial class FormUrunGuncelle : Form
    {
        MyConnection _myCon = new MyConnection();
        public FormUrunGuncelle()
        {
            InitializeComponent();
            txt_UrunID.ReadOnly = true;
            txt_UrunKodu.ReadOnly = true;
            txt_UrunAdi.ReadOnly = true;
            txt_UrunFiyat.ReadOnly = true;
            txt_Aciklama.ReadOnly = true;

            txt_UrunID.Text = FormUrunListele.dataTasi.Cells["Ürün ID"].Value.ToString();
            txt_UrunKodu.Text = FormUrunListele.dataTasi.Cells["Ürün Kodu"].Value.ToString();
            txt_UrunAdi.Text = FormUrunListele.dataTasi.Cells["Ürün Adı"].Value.ToString();
            txt_UrunFiyat.Text = FormUrunListele.dataTasi.Cells["Ürün Fiyat"].Value.ToString();
            txt_Aciklama.Text = FormUrunListele.dataTasi.Cells["Ürün Açıklama"].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
