using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakipSistemi
{
    public partial class FormLogin : Form
    {
        public bool loginOldumu = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {            
                if (txt_KullaniciAdi.Text == "Baynet" && txt_Sifre.Text == "Baynet2022")
                {                   
                    loginOldumu = true;
                    this.Hide();
                }              
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
        }

        private void btn_Vazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_KullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
