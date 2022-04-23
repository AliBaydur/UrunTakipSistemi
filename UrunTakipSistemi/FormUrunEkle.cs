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
    public partial class FormUrunEkle : Form
    {
        MyConnection _myCon = new MyConnection();
        public FormUrunEkle()
        {
            InitializeComponent();
            AnaKategoriGetir();
        }
        private void AnaKategoriGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID, KategoriAdi FROM Tbl_Kategori WHERE KategoriDurum=1", _myCon.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            cbx_KategoriSec.Text = "Seçiniz...";

            while (dr.Read())
            {
                cbx_KategoriSec.Items.Add(new ComboBoxValue(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }
            dr.Close();
        }

        private void AltKategoriGetir()
        {
            ComboBoxValue combo = (ComboBoxValue)cbx_KategoriSec.SelectedItem;
            cbx_AltKategoriSec.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT AltKategoriID, AltKategoriAdi FROM Tbl_AltKategori WHERE AltKategoriDurum = 1 AND KategoriID = @ID", _myCon.connection());
            cmd.Parameters.AddWithValue("@ID", combo.Id);
            SqlDataReader dr = cmd.ExecuteReader();
            cbx_AltKategoriSec.Text = "Seçiniz...";

            while (dr.Read())
            {
                cbx_AltKategoriSec.Items.Add(new ComboBoxValue(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }
            dr.Close();
        }

        private void FormUrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void cbx_KategoriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            AltKategoriGetir();
        }

        private void UrunEkle()
        {
            ComboBoxValue comboMain = (ComboBoxValue)cbx_KategoriSec.SelectedItem;
            ComboBoxValue comboSub = (ComboBoxValue)cbx_AltKategoriSec.SelectedItem;

            SqlCommand cmd = new SqlCommand("SP_UrunEkle",_myCon.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KatID", comboMain.Id);
            cmd.Parameters.AddWithValue("@AltID", comboSub.Id);
            cmd.Parameters.AddWithValue("@UrnKod", txt_UrunKodu.Text.ToString());
            cmd.Parameters.AddWithValue("@UrnNam", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@UrnFyt", txt_Fiyat.Value);
            cmd.Parameters.AddWithValue("@UrnAck", txt_UrunAciklama.Text.ToString());
            cmd.Parameters.AddWithValue("@UrnDrm", cbx_AktifUrun.Checked);
            cmd.ExecuteNonQuery();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                UrunEkle();
                MessageBox.Show("Ürün başarılı bir şekilde eklenmiştir.","Kayıt", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Mesajı: " + ex.Message.ToString());
                throw;
            }          
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
