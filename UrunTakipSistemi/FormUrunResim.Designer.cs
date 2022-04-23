
namespace UrunTakipSistemi
{
    partial class FormUrunResim
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_UrunSec = new System.Windows.Forms.ComboBox();
            this.cbx_AltKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_KategoriSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Yukle1 = new System.Windows.Forms.Button();
            this.pb_Resim1 = new System.Windows.Forms.PictureBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Resim1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_UrunSec);
            this.groupBox1.Controls.Add(this.cbx_AltKategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_KategoriSec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Seç";
            // 
            // cbx_UrunSec
            // 
            this.cbx_UrunSec.FormattingEnabled = true;
            this.cbx_UrunSec.Location = new System.Drawing.Point(135, 88);
            this.cbx_UrunSec.Name = "cbx_UrunSec";
            this.cbx_UrunSec.Size = new System.Drawing.Size(154, 24);
            this.cbx_UrunSec.TabIndex = 1;
            // 
            // cbx_AltKategori
            // 
            this.cbx_AltKategori.FormattingEnabled = true;
            this.cbx_AltKategori.Location = new System.Drawing.Point(135, 58);
            this.cbx_AltKategori.Name = "cbx_AltKategori";
            this.cbx_AltKategori.Size = new System.Drawing.Size(154, 24);
            this.cbx_AltKategori.TabIndex = 1;
            this.cbx_AltKategori.SelectedIndexChanged += new System.EventHandler(this.cbx_AltKategori_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Seçiniz";
            // 
            // cbx_KategoriSec
            // 
            this.cbx_KategoriSec.FormattingEnabled = true;
            this.cbx_KategoriSec.Location = new System.Drawing.Point(135, 26);
            this.cbx_KategoriSec.Name = "cbx_KategoriSec";
            this.cbx_KategoriSec.Size = new System.Drawing.Size(154, 24);
            this.cbx_KategoriSec.TabIndex = 1;
            this.cbx_KategoriSec.SelectedIndexChanged += new System.EventHandler(this.cbx_KategoriSec_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alt Kategori Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Seçiniz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Yukle1);
            this.groupBox2.Controls.Add(this.pb_Resim1);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resim Ekle";
            // 
            // btn_Yukle1
            // 
            this.btn_Yukle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yukle1.Location = new System.Drawing.Point(245, 271);
            this.btn_Yukle1.Name = "btn_Yukle1";
            this.btn_Yukle1.Size = new System.Drawing.Size(83, 30);
            this.btn_Yukle1.TabIndex = 1;
            this.btn_Yukle1.Text = "Yükle";
            this.btn_Yukle1.UseVisualStyleBackColor = true;
            this.btn_Yukle1.Click += new System.EventHandler(this.btn_Yukle1_Click);
            // 
            // pb_Resim1
            // 
            this.pb_Resim1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Resim1.Location = new System.Drawing.Point(9, 21);
            this.pb_Resim1.Name = "pb_Resim1";
            this.pb_Resim1.Size = new System.Drawing.Size(319, 235);
            this.pb_Resim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Resim1.TabIndex = 0;
            this.pb_Resim1.TabStop = false;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(508, 325);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(83, 32);
            this.btn_Kaydet.TabIndex = 1;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(597, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vazgeç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUrunResim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(700, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUrunResim";
            this.Text = "Resim Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Resim1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_UrunSec;
        private System.Windows.Forms.ComboBox cbx_AltKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_KategoriSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Yukle1;
        private System.Windows.Forms.PictureBox pb_Resim1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button button1;
    }
}