
namespace UrunTakipSistemi
{
    partial class FormMainKategori
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
            this.gb_KategoriAdd = new System.Windows.Forms.GroupBox();
            this.lbl_KategoriDurum = new System.Windows.Forms.Label();
            this.btn_KategoriEkle = new System.Windows.Forms.Button();
            this.txt_KategoriAdi = new System.Windows.Forms.TextBox();
            this.lbl_KategoriAdi = new System.Windows.Forms.Label();
            this.gb_KategoriListele = new System.Windows.Forms.GroupBox();
            this.dgw_Kategori = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_KategoriAdd.SuspendLayout();
            this.gb_KategoriListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Kategori)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_KategoriAdd
            // 
            this.gb_KategoriAdd.Controls.Add(this.lbl_KategoriDurum);
            this.gb_KategoriAdd.Controls.Add(this.button1);
            this.gb_KategoriAdd.Controls.Add(this.btn_KategoriEkle);
            this.gb_KategoriAdd.Controls.Add(this.txt_KategoriAdi);
            this.gb_KategoriAdd.Controls.Add(this.lbl_KategoriAdi);
            this.gb_KategoriAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_KategoriAdd.Location = new System.Drawing.Point(16, 15);
            this.gb_KategoriAdd.Margin = new System.Windows.Forms.Padding(4);
            this.gb_KategoriAdd.Name = "gb_KategoriAdd";
            this.gb_KategoriAdd.Padding = new System.Windows.Forms.Padding(4);
            this.gb_KategoriAdd.Size = new System.Drawing.Size(392, 97);
            this.gb_KategoriAdd.TabIndex = 0;
            this.gb_KategoriAdd.TabStop = false;
            this.gb_KategoriAdd.Text = "Kategori Ekle";
            // 
            // lbl_KategoriDurum
            // 
            this.lbl_KategoriDurum.AutoSize = true;
            this.lbl_KategoriDurum.ForeColor = System.Drawing.Color.Red;
            this.lbl_KategoriDurum.Location = new System.Drawing.Point(28, 73);
            this.lbl_KategoriDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KategoriDurum.Name = "lbl_KategoriDurum";
            this.lbl_KategoriDurum.Size = new System.Drawing.Size(0, 16);
            this.lbl_KategoriDurum.TabIndex = 3;
            // 
            // btn_KategoriEkle
            // 
            this.btn_KategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KategoriEkle.Location = new System.Drawing.Point(217, 53);
            this.btn_KategoriEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KategoriEkle.Name = "btn_KategoriEkle";
            this.btn_KategoriEkle.Size = new System.Drawing.Size(66, 27);
            this.btn_KategoriEkle.TabIndex = 2;
            this.btn_KategoriEkle.Text = "Ekle";
            this.btn_KategoriEkle.UseVisualStyleBackColor = true;
            this.btn_KategoriEkle.Click += new System.EventHandler(this.btn_KategoriEkle_Click);
            // 
            // txt_KategoriAdi
            // 
            this.txt_KategoriAdi.Location = new System.Drawing.Point(127, 23);
            this.txt_KategoriAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KategoriAdi.Name = "txt_KategoriAdi";
            this.txt_KategoriAdi.Size = new System.Drawing.Size(223, 22);
            this.txt_KategoriAdi.TabIndex = 1;
            // 
            // lbl_KategoriAdi
            // 
            this.lbl_KategoriAdi.AutoSize = true;
            this.lbl_KategoriAdi.Location = new System.Drawing.Point(11, 26);
            this.lbl_KategoriAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KategoriAdi.Name = "lbl_KategoriAdi";
            this.lbl_KategoriAdi.Size = new System.Drawing.Size(81, 16);
            this.lbl_KategoriAdi.TabIndex = 0;
            this.lbl_KategoriAdi.Text = "Kategori Adı";
            // 
            // gb_KategoriListele
            // 
            this.gb_KategoriListele.Controls.Add(this.dgw_Kategori);
            this.gb_KategoriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_KategoriListele.Location = new System.Drawing.Point(16, 119);
            this.gb_KategoriListele.Margin = new System.Windows.Forms.Padding(4);
            this.gb_KategoriListele.Name = "gb_KategoriListele";
            this.gb_KategoriListele.Padding = new System.Windows.Forms.Padding(4);
            this.gb_KategoriListele.Size = new System.Drawing.Size(879, 218);
            this.gb_KategoriListele.TabIndex = 1;
            this.gb_KategoriListele.TabStop = false;
            this.gb_KategoriListele.Text = "Kategori Listele Güncelle ve Sil";
            // 
            // dgw_Kategori
            // 
            this.dgw_Kategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Kategori.Location = new System.Drawing.Point(8, 23);
            this.dgw_Kategori.Margin = new System.Windows.Forms.Padding(4);
            this.dgw_Kategori.Name = "dgw_Kategori";
            this.dgw_Kategori.Size = new System.Drawing.Size(861, 185);
            this.dgw_Kategori.TabIndex = 0;
            this.dgw_Kategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Kategori_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(285, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vazgeç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMainKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(902, 371);
            this.Controls.Add(this.gb_KategoriListele);
            this.Controls.Add(this.gb_KategoriAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainKategori";
            this.Text = "Ana Kategori İşlemleri";
            this.gb_KategoriAdd.ResumeLayout(false);
            this.gb_KategoriAdd.PerformLayout();
            this.gb_KategoriListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Kategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_KategoriAdd;
        private System.Windows.Forms.Label lbl_KategoriDurum;
        private System.Windows.Forms.Button btn_KategoriEkle;
        private System.Windows.Forms.TextBox txt_KategoriAdi;
        private System.Windows.Forms.Label lbl_KategoriAdi;
        private System.Windows.Forms.GroupBox gb_KategoriListele;
        private System.Windows.Forms.DataGridView dgw_Kategori;
        private System.Windows.Forms.Button button1;
    }
}