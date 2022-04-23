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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormLogin formLogin = new FormLogin();
            if (formLogin.loginOldumu == false)
            {
                formLogin.ShowDialog();
                //Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMainKategori formMainKategori = new FormMainKategori();
            formMainKategori.ShowDialog();
        }

        private void altKategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubCat formSubCat = new FormSubCat();
            formSubCat.ShowDialog();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunEkle formUrunEkle = new FormUrunEkle();
            formUrunEkle.ShowDialog();
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UrunListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunListele formUrunListele = new FormUrunListele();
            formUrunListele.ShowDialog();
        }

        private void UrunResimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrunResim formUrunResim = new FormUrunResim();
            formUrunResim.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
