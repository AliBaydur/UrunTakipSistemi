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
    public partial class FormMainKategori : Form
    {
        MyConnection _myCon = new MyConnection();
        public FormMainKategori()
        {
            InitializeComponent();
            DataGetir();
            DataButonEkle();
        }

        private void DataGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT KategoriID, KategoriAdi, KategoriDurum, KategoriTarih FROM Tbl_Kategori", _myCon.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dgw_Kategori.DataSource = ds.Tables[0];
            dgw_Kategori.AutoGenerateColumns = false;
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
            dgw_Kategori.Columns.Add(EditLink);

            //Gride Silme Butonunu Ekliyoruz.
            DataGridViewLinkColumn DeleteLink = new DataGridViewLinkColumn();
            DeleteLink.UseColumnTextForLinkValue = true;
            DeleteLink.HeaderText = "Sil";
            DeleteLink.DataPropertyName = "lnkColumn";
            DeleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            DeleteLink.Text = "Sil";
            dgw_Kategori.Columns.Add(DeleteLink);
        }

        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            AnaKategoriEkle();
        }

        private void AnaKategoriEkle()
        {
            if (txt_KategoriAdi.Text.ToString() != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Kategori(KategoriAdi) VALUES('" + txt_KategoriAdi.Text.ToString() + "')", _myCon.connection());
                cmd.ExecuteNonQuery();
                lbl_KategoriDurum.Text = "Durum: " + txt_KategoriAdi.Text.ToString() + " adlı kategori başarılı bir şekilde eklendi.";
                DataGetir();
            }
            else
            {
                lbl_KategoriDurum.Text = "Geçerli bir değer giriniz!";
            }
        }

        private void dgw_Kategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string id = dgw_Kategori.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                string ad = dgw_Kategori.Rows[e.RowIndex].Cells["KategoriAdi"].Value.ToString();
                byte durum = Convert.ToByte(dgw_Kategori.Rows[e.RowIndex].Cells["KategoriDurum"].Value);
                KategoriGuncelle(id, ad, durum);
            }
            else if (e.ColumnIndex == 5)
            {
                string id = dgw_Kategori.Rows[e.RowIndex].Cells["KategoriID"].Value.ToString();
                KategoriSil(id);
            }
        }

        private void KategoriGuncelle(string _id, string _ad, byte _durum)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Kategori SET KategoriAdi='" + _ad + "',KategoriDurum= " + _durum + "" +
                "WHERE KategoriID = " + _id + "", _myCon.connection());
            cmd.ExecuteNonQuery();

            DataGetir();

            MessageBox.Show(_id + " Numaralı Kategori Güncelleme İşlemi Başarılı...");
        }

        private void KategoriSil(string _id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Kategori WHERE KategoriID = " + _id, _myCon.connection());
            cmd.ExecuteNonQuery();
            DataGetir();
            MessageBox.Show(_id + "Numaralı Kategori Başarılı Bir Şekilde Silindi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
