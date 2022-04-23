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
    public partial class FormSubCat : Form
    {
        MyConnection _myCon = new MyConnection();
        public FormSubCat()
        {
            InitializeComponent();
            AnaKategoriGetir();
            DataGetir();
            DataButonEkle();
        }
         
        private void AnaKategoriGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID, KategoriAdi FROM Tbl_Kategori WHERE KategoriDurum=1",_myCon.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            cbx_AnaKategoriSec.Text = "Seçiniz...";
            
            while (dr.Read())
            {
                cbx_AnaKategoriSec.Items.Add(new ComboBoxValue(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }
            dr.Close();
        }

        private void DataGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT AltKategoriID, KategoriID, AltKategoriAdi, AltKategoriDurum, AltKategoriTarih" +
                " FROM Tbl_AltKategori",_myCon.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.AutoGenerateColumns = false;            
        }

        private void DataButonEkle()
        {
            //Gride Ekleme Butonunu Ekliyoruz.
            DataGridViewLinkColumn EditLink = new DataGridViewLinkColumn();
            EditLink.UseColumnTextForLinkValue = true;
            EditLink.HeaderText = "Güncelle";
            EditLink.DataPropertyName = "lnkColumn";
            EditLink.LinkBehavior = LinkBehavior.SystemDefault;
            EditLink.Text = "Güncelle";
            dataGridView1.Columns.Add(EditLink);

            //Gride Silme Butonunu Ekliyoruz.
            DataGridViewLinkColumn DeleteLink = new DataGridViewLinkColumn();
            DeleteLink.UseColumnTextForLinkValue = true;
            DeleteLink.HeaderText = "Sil";
            DeleteLink.DataPropertyName = "lnkColumn";
            DeleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            DeleteLink.Text = "Sil";
            dataGridView1.Columns.Add(DeleteLink);
        }

        private void AltKategoriEkle()
        {
            ComboBoxValue cb = (ComboBoxValue)cbx_AnaKategoriSec.SelectedItem;

            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_AltKategori (KategoriID, AltKategoriAdi) VALUES (@ID, @AD)",
                _myCon.connection());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", cb.Id);
            cmd.Parameters.AddWithValue("@AD", tbx_KategoriIsmi.Text);
            cmd.ExecuteNonQuery();
        }

        private void tbx_KategoriIsmi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AltKategoriEkle_Click(object sender, EventArgs e)
        {
            if (cbx_AnaKategoriSec.SelectedItem != null)
            {
                if (tbx_KategoriIsmi.Text.ToString() != null)
                {
                    AltKategoriEkle();
                    DataGetir();
                    lbl_AltKategoriDurum.Text = "Alt kategori başarılı bir şekilde eklendi...";
                }
                else
                {
                    lbl_AltKategoriDurum.Text = "Lütfen geçerli bir kategori giriniz...";
                }
            }
            else
            {
                lbl_AltKategoriDurum.Text = "Durum: Lütfen ana kategori seçiniz!";
            }
        }

        private void KategoriSil(string _id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_AltKategori WHERE AltKategoriID = " + _id, _myCon.connection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show(_id + " Numaralı Kategori Başarılı Bir Şekilde Silindi.");
        }

        private void KategoriGuncelle(string _id, string _ad, byte _durum)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_AltKategori SET AltKategoriAdi='" + _ad + "', AltKategoriDurum= " + _durum + "" +
                "WHERE AltKategoriID = " + _id + "", _myCon.connection());
            cmd.ExecuteNonQuery();

            DataGetir();

            MessageBox.Show(_id + " Numaralı Kategori Güncelleme İşlemi Başarılı...");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["AltKategoriID"].Value.ToString();
                string ad = dataGridView1.Rows[e.RowIndex].Cells["AltKategoriAdi"].Value.ToString();
                byte durum = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells["AltKategoriDurum"].Value);
                KategoriGuncelle(id, ad, durum);
            }
            else if (e.ColumnIndex == 6)
            {
                DialogResult secim = new DialogResult();
                secim = MessageBox.Show("Emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (secim == DialogResult.Yes)
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["AltKategoriID"].Value.ToString();
                    KategoriSil(id);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
