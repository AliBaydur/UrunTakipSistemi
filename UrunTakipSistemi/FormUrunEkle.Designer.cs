
namespace UrunTakipSistemi
{
    partial class FormUrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_KategoriIslemleri = new System.Windows.Forms.GroupBox();
            this.cbx_AltKategoriSec = new System.Windows.Forms.ComboBox();
            this.cbx_KategoriSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_UrunIslem = new System.Windows.Forms.GroupBox();
            this.txt_Fiyat = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.txt_UrunKodu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_UrunDetay = new System.Windows.Forms.GroupBox();
            this.txt_UrunAciklama = new System.Windows.Forms.TextBox();
            this.cbx_AktifUrun = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.gb_KategoriIslemleri.SuspendLayout();
            this.gb_UrunIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fiyat)).BeginInit();
            this.gb_UrunDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_KategoriIslemleri
            // 
            this.gb_KategoriIslemleri.Controls.Add(this.cbx_AltKategoriSec);
            this.gb_KategoriIslemleri.Controls.Add(this.cbx_KategoriSec);
            this.gb_KategoriIslemleri.Controls.Add(this.label2);
            this.gb_KategoriIslemleri.Controls.Add(this.label1);
            this.gb_KategoriIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_KategoriIslemleri.Location = new System.Drawing.Point(12, 12);
            this.gb_KategoriIslemleri.Name = "gb_KategoriIslemleri";
            this.gb_KategoriIslemleri.Size = new System.Drawing.Size(760, 66);
            this.gb_KategoriIslemleri.TabIndex = 0;
            this.gb_KategoriIslemleri.TabStop = false;
            this.gb_KategoriIslemleri.Text = "Kategori İşlemleri";
            // 
            // cbx_AltKategoriSec
            // 
            this.cbx_AltKategoriSec.FormattingEnabled = true;
            this.cbx_AltKategoriSec.Location = new System.Drawing.Point(530, 27);
            this.cbx_AltKategoriSec.Name = "cbx_AltKategoriSec";
            this.cbx_AltKategoriSec.Size = new System.Drawing.Size(167, 24);
            this.cbx_AltKategoriSec.TabIndex = 1;
            // 
            // cbx_KategoriSec
            // 
            this.cbx_KategoriSec.FormattingEnabled = true;
            this.cbx_KategoriSec.Location = new System.Drawing.Point(143, 27);
            this.cbx_KategoriSec.Name = "cbx_KategoriSec";
            this.cbx_KategoriSec.Size = new System.Drawing.Size(167, 24);
            this.cbx_KategoriSec.TabIndex = 0;
            this.cbx_KategoriSec.SelectedIndexChanged += new System.EventHandler(this.cbx_KategoriSec_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alt Kategori Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Seçiniz";
            // 
            // gb_UrunIslem
            // 
            this.gb_UrunIslem.Controls.Add(this.txt_Fiyat);
            this.gb_UrunIslem.Controls.Add(this.textBox2);
            this.gb_UrunIslem.Controls.Add(this.txt_UrunAdi);
            this.gb_UrunIslem.Controls.Add(this.txt_UrunKodu);
            this.gb_UrunIslem.Controls.Add(this.label5);
            this.gb_UrunIslem.Controls.Add(this.label4);
            this.gb_UrunIslem.Controls.Add(this.label3);
            this.gb_UrunIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_UrunIslem.Location = new System.Drawing.Point(13, 84);
            this.gb_UrunIslem.Name = "gb_UrunIslem";
            this.gb_UrunIslem.Size = new System.Drawing.Size(759, 75);
            this.gb_UrunIslem.TabIndex = 1;
            this.gb_UrunIslem.TabStop = false;
            this.gb_UrunIslem.Text = "Ürün İşlemleri";
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.DecimalPlaces = 2;
            this.txt_Fiyat.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txt_Fiyat.Location = new System.Drawing.Point(565, 37);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(69, 22);
            this.txt_Fiyat.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 38);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 3;
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(299, 37);
            this.txt_UrunAdi.MaxLength = 50;
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(141, 22);
            this.txt_UrunAdi.TabIndex = 1;
            // 
            // txt_UrunKodu
            // 
            this.txt_UrunKodu.Location = new System.Drawing.Point(119, 40);
            this.txt_UrunKodu.MaxLength = 5;
            this.txt_UrunKodu.Name = "txt_UrunKodu";
            this.txt_UrunKodu.Size = new System.Drawing.Size(70, 22);
            this.txt_UrunKodu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Kodu";
            // 
            // gb_UrunDetay
            // 
            this.gb_UrunDetay.Controls.Add(this.txt_UrunAciklama);
            this.gb_UrunDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_UrunDetay.Location = new System.Drawing.Point(12, 183);
            this.gb_UrunDetay.Name = "gb_UrunDetay";
            this.gb_UrunDetay.Size = new System.Drawing.Size(760, 166);
            this.gb_UrunDetay.TabIndex = 2;
            this.gb_UrunDetay.TabStop = false;
            this.gb_UrunDetay.Text = "Ürün Detay";
            // 
            // txt_UrunAciklama
            // 
            this.txt_UrunAciklama.Location = new System.Drawing.Point(6, 21);
            this.txt_UrunAciklama.Multiline = true;
            this.txt_UrunAciklama.Name = "txt_UrunAciklama";
            this.txt_UrunAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_UrunAciklama.Size = new System.Drawing.Size(748, 139);
            this.txt_UrunAciklama.TabIndex = 5;
            // 
            // cbx_AktifUrun
            // 
            this.cbx_AktifUrun.AutoSize = true;
            this.cbx_AktifUrun.Checked = true;
            this.cbx_AktifUrun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_AktifUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_AktifUrun.Location = new System.Drawing.Point(470, 367);
            this.cbx_AktifUrun.Name = "cbx_AktifUrun";
            this.cbx_AktifUrun.Size = new System.Drawing.Size(83, 20);
            this.cbx_AktifUrun.TabIndex = 6;
            this.cbx_AktifUrun.Text = "Aktif Ürün";
            this.cbx_AktifUrun.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(590, 360);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 31);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kapat.Location = new System.Drawing.Point(686, 360);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(80, 31);
            this.btn_Kapat.TabIndex = 7;
            this.btn_Kapat.Text = "Kapat";
            this.btn_Kapat.UseVisualStyleBackColor = true;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(784, 398);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbx_AktifUrun);
            this.Controls.Add(this.gb_UrunDetay);
            this.Controls.Add(this.gb_UrunIslem);
            this.Controls.Add(this.gb_KategoriIslemleri);
            this.Name = "FormUrunEkle";
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.FormUrunEkle_Load);
            this.gb_KategoriIslemleri.ResumeLayout(false);
            this.gb_KategoriIslemleri.PerformLayout();
            this.gb_UrunIslem.ResumeLayout(false);
            this.gb_UrunIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fiyat)).EndInit();
            this.gb_UrunDetay.ResumeLayout(false);
            this.gb_UrunDetay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_KategoriIslemleri;
        private System.Windows.Forms.ComboBox cbx_AltKategoriSec;
        private System.Windows.Forms.ComboBox cbx_KategoriSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_UrunIslem;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.TextBox txt_UrunKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_Fiyat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_UrunDetay;
        private System.Windows.Forms.TextBox txt_UrunAciklama;
        private System.Windows.Forms.CheckBox cbx_AktifUrun;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btn_Kapat;
    }
}