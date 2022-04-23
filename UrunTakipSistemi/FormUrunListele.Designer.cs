
namespace UrunTakipSistemi
{
    partial class FormUrunListele
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
            this.gb_UrunKategoriListele = new System.Windows.Forms.GroupBox();
            this.btn_Getir = new System.Windows.Forms.Button();
            this.cb_AltKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UrunKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.gb_UrunKategoriListele.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_UrunKategoriListele
            // 
            this.gb_UrunKategoriListele.Controls.Add(this.btn_Getir);
            this.gb_UrunKategoriListele.Controls.Add(this.cb_AltKategori);
            this.gb_UrunKategoriListele.Controls.Add(this.label2);
            this.gb_UrunKategoriListele.Controls.Add(this.cbx_Kategori);
            this.gb_UrunKategoriListele.Controls.Add(this.label1);
            this.gb_UrunKategoriListele.Location = new System.Drawing.Point(12, 12);
            this.gb_UrunKategoriListele.Name = "gb_UrunKategoriListele";
            this.gb_UrunKategoriListele.Size = new System.Drawing.Size(448, 100);
            this.gb_UrunKategoriListele.TabIndex = 0;
            this.gb_UrunKategoriListele.TabStop = false;
            this.gb_UrunKategoriListele.Text = "ÜrünKategori";
            // 
            // btn_Getir
            // 
            this.btn_Getir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Getir.Location = new System.Drawing.Point(320, 59);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(85, 28);
            this.btn_Getir.TabIndex = 2;
            this.btn_Getir.Text = "Getir";
            this.btn_Getir.UseVisualStyleBackColor = true;
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // cb_AltKategori
            // 
            this.cb_AltKategori.FormattingEnabled = true;
            this.cb_AltKategori.Location = new System.Drawing.Point(103, 59);
            this.cb_AltKategori.Name = "cb_AltKategori";
            this.cb_AltKategori.Size = new System.Drawing.Size(160, 24);
            this.cb_AltKategori.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alt Kategori";
            // 
            // cbx_Kategori
            // 
            this.cbx_Kategori.FormattingEnabled = true;
            this.cbx_Kategori.Location = new System.Drawing.Point(103, 29);
            this.cbx_Kategori.Name = "cbx_Kategori";
            this.cbx_Kategori.Size = new System.Drawing.Size(160, 24);
            this.cbx_Kategori.TabIndex = 1;
            this.cbx_Kategori.SelectedIndexChanged += new System.EventHandler(this.cbx_Kategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ara);
            this.groupBox1.Controls.Add(this.txt_UrunAdi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_UrunKodu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(481, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ara";
            // 
            // btn_Ara
            // 
            this.btn_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ara.Location = new System.Drawing.Point(317, 59);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(85, 28);
            this.btn_Ara.TabIndex = 2;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(100, 65);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(160, 22);
            this.txt_UrunAdi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "veya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Adı";
            // 
            // txt_UrunKodu
            // 
            this.txt_UrunKodu.Location = new System.Drawing.Point(100, 21);
            this.txt_UrunKodu.Name = "txt_UrunKodu";
            this.txt_UrunKodu.Size = new System.Drawing.Size(160, 22);
            this.txt_UrunKodu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Kodu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kapat.Location = new System.Drawing.Point(832, 365);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(111, 35);
            this.btn_Kapat.TabIndex = 2;
            this.btn_Kapat.Text = "Kapat";
            this.btn_Kapat.UseVisualStyleBackColor = true;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // FormUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(955, 412);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_UrunKategoriListele);
            this.Name = "FormUrunListele";
            this.Text = "Ürün Listele";
            this.gb_UrunKategoriListele.ResumeLayout(false);
            this.gb_UrunKategoriListele.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_UrunKategoriListele;
        private System.Windows.Forms.Button btn_Getir;
        private System.Windows.Forms.ComboBox cb_AltKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UrunKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Kapat;
    }
}