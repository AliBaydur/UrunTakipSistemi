using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakipSistemi
{
    public partial class FormUrunResim : Form
    {
        MyConnection _myCon = new MyConnection();
        public FormUrunResim()
        {
            InitializeComponent();
            cbx_KategoriSec.Items.AddRange(VeriGetir("SELECT KategoriID, KategoriAdi FROM Tbl_Kategori"));
        }

        private object[] VeriGetir(string komut)
        {    
            SqlCommand cmd = new SqlCommand(komut, _myCon.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            object[] urunveriler = new object[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                urunveriler[i] = new ComboBoxValue(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1].ToString());
            }

            return urunveriler;
        }

        private void cbx_KategoriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxValue combo = (ComboBoxValue)cbx_KategoriSec.SelectedItem;
            cbx_AltKategori.Items.AddRange(VeriGetir("SELECT AltKategoriID, AltKategoriAdi FROM Tbl_AltKategori " +
                "WHERE KategoriID=" + combo.Id.ToString() + " "));
        }

        private void cbx_AltKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxValue combo = (ComboBoxValue)cbx_AltKategori.SelectedItem;

            cbx_UrunSec.Items.AddRange(VeriGetir("SELECT UrunID, UrunAdi FROM Tbl_Urun " +
                "WHERE AltKategoriID =" + combo.Id.ToString() + " "));
        }

        private OpenFileDialog OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Dosyasını Aç";
            ofd.Filter = "PNG Files(*.png) | *.png | JPG Files (*.jpg) | *.jpg | Tüm Dosyalar (*.*) | *.*";
            ofd.FilterIndex = 3;
            DialogResult dr = ofd.ShowDialog();
            return ofd;
        }


        private void btn_Yukle1_Click(object sender, EventArgs e)
        {
            pb_Resim1.ImageLocation = OpenFile().FileName;
        }

        private void btn_Yukle2_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Yukle3_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (pb_Resim1.ImageLocation != "")
            {
                Guid guid = Guid.NewGuid();

                string kaynak = pb_Resim1.ImageLocation;
                string hedef = @"C:\Users\Ali\source\repos\UrunTakipSistemi\UrunTakipSistemi\Images\" + guid + ".png";
                File.Copy(kaynak, hedef, true);

                DialogResult result = MessageBox.Show("Resim Yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Lütfen Resim Yükleyiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
