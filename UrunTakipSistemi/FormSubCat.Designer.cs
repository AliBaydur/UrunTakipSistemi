
namespace UrunTakipSistemi
{
    partial class FormSubCat
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
            this.gb_AltKategoriEkle = new System.Windows.Forms.GroupBox();
            this.btn_AltKategoriEkle = new System.Windows.Forms.Button();
            this.tbx_KategoriIsmi = new System.Windows.Forms.TextBox();
            this.cbx_AnaKategoriSec = new System.Windows.Forms.ComboBox();
            this.lbl_AltKategoriDurum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_AltKategoriGoster = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_AltKategoriEkle.SuspendLayout();
            this.gb_AltKategoriGoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_AltKategoriEkle
            // 
            this.gb_AltKategoriEkle.Controls.Add(this.button1);
            this.gb_AltKategoriEkle.Controls.Add(this.btn_AltKategoriEkle);
            this.gb_AltKategoriEkle.Controls.Add(this.tbx_KategoriIsmi);
            this.gb_AltKategoriEkle.Controls.Add(this.cbx_AnaKategoriSec);
            this.gb_AltKategoriEkle.Controls.Add(this.lbl_AltKategoriDurum);
            this.gb_AltKategoriEkle.Controls.Add(this.label2);
            this.gb_AltKategoriEkle.Controls.Add(this.label1);
            this.gb_AltKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_AltKategoriEkle.Location = new System.Drawing.Point(12, 12);
            this.gb_AltKategoriEkle.Name = "gb_AltKategoriEkle";
            this.gb_AltKategoriEkle.Size = new System.Drawing.Size(1032, 100);
            this.gb_AltKategoriEkle.TabIndex = 0;
            this.gb_AltKategoriEkle.TabStop = false;
            this.gb_AltKategoriEkle.Text = "Alt Kategori Ekle";
            // 
            // btn_AltKategoriEkle
            // 
            this.btn_AltKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AltKategoriEkle.Location = new System.Drawing.Point(393, 21);
            this.btn_AltKategoriEkle.Name = "btn_AltKategoriEkle";
            this.btn_AltKategoriEkle.Size = new System.Drawing.Size(80, 27);
            this.btn_AltKategoriEkle.TabIndex = 3;
            this.btn_AltKategoriEkle.Text = "Ekle";
            this.btn_AltKategoriEkle.UseVisualStyleBackColor = true;
            this.btn_AltKategoriEkle.Click += new System.EventHandler(this.btn_AltKategoriEkle_Click);
            // 
            // tbx_KategoriIsmi
            // 
            this.tbx_KategoriIsmi.Location = new System.Drawing.Point(189, 58);
            this.tbx_KategoriIsmi.Name = "tbx_KategoriIsmi";
            this.tbx_KategoriIsmi.Size = new System.Drawing.Size(160, 22);
            this.tbx_KategoriIsmi.TabIndex = 2;
            this.tbx_KategoriIsmi.TextChanged += new System.EventHandler(this.tbx_KategoriIsmi_TextChanged);
            // 
            // cbx_AnaKategoriSec
            // 
            this.cbx_AnaKategoriSec.FormattingEnabled = true;
            this.cbx_AnaKategoriSec.Location = new System.Drawing.Point(189, 24);
            this.cbx_AnaKategoriSec.Name = "cbx_AnaKategoriSec";
            this.cbx_AnaKategoriSec.Size = new System.Drawing.Size(160, 24);
            this.cbx_AnaKategoriSec.TabIndex = 1;
            // 
            // lbl_AltKategoriDurum
            // 
            this.lbl_AltKategoriDurum.AutoSize = true;
            this.lbl_AltKategoriDurum.ForeColor = System.Drawing.Color.Red;
            this.lbl_AltKategoriDurum.Location = new System.Drawing.Point(390, 61);
            this.lbl_AltKategoriDurum.Name = "lbl_AltKategoriDurum";
            this.lbl_AltKategoriDurum.Size = new System.Drawing.Size(0, 16);
            this.lbl_AltKategoriDurum.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ana Kategori İsmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Kategori Seçiniz";
            // 
            // gb_AltKategoriGoster
            // 
            this.gb_AltKategoriGoster.Controls.Add(this.dataGridView1);
            this.gb_AltKategoriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_AltKategoriGoster.Location = new System.Drawing.Point(12, 118);
            this.gb_AltKategoriGoster.Name = "gb_AltKategoriGoster";
            this.gb_AltKategoriGoster.Size = new System.Drawing.Size(1032, 231);
            this.gb_AltKategoriGoster.TabIndex = 1;
            this.gb_AltKategoriGoster.TabStop = false;
            this.gb_AltKategoriGoster.Text = "Alt Kategori Listele Güncelle ve Sil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(479, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vazgeç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSubCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1054, 361);
            this.Controls.Add(this.gb_AltKategoriGoster);
            this.Controls.Add(this.gb_AltKategoriEkle);
            this.Name = "FormSubCat";
            this.Text = "Alt Kategori İşlemleri";
            this.gb_AltKategoriEkle.ResumeLayout(false);
            this.gb_AltKategoriEkle.PerformLayout();
            this.gb_AltKategoriGoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_AltKategoriEkle;
        private System.Windows.Forms.GroupBox gb_AltKategoriGoster;
        private System.Windows.Forms.Button btn_AltKategoriEkle;
        private System.Windows.Forms.TextBox tbx_KategoriIsmi;
        private System.Windows.Forms.ComboBox cbx_AnaKategoriSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_AltKategoriDurum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}