
namespace UrunTakipSistemi
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altKategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunResimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriİşlemleriToolStripMenuItem,
            this.altKategoriİşlemleriToolStripMenuItem,
            this.ürünİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1040, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            this.kategoriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kategoriİşlemleriToolStripMenuItem_Click);
            // 
            // altKategoriİşlemleriToolStripMenuItem
            // 
            this.altKategoriİşlemleriToolStripMenuItem.Name = "altKategoriİşlemleriToolStripMenuItem";
            this.altKategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.altKategoriİşlemleriToolStripMenuItem.Text = "Alt Kategori İşlemleri";
            this.altKategoriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.altKategoriİşlemleriToolStripMenuItem_Click);
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrunEkleToolStripMenuItem,
            this.UrunListeleToolStripMenuItem,
            this.UrunResimEkleToolStripMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            this.ürünİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.ürünİşlemleriToolStripMenuItem_Click);
            // 
            // UrunEkleToolStripMenuItem
            // 
            this.UrunEkleToolStripMenuItem.Name = "UrunEkleToolStripMenuItem";
            this.UrunEkleToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.UrunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.UrunEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // UrunListeleToolStripMenuItem
            // 
            this.UrunListeleToolStripMenuItem.Name = "UrunListeleToolStripMenuItem";
            this.UrunListeleToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.UrunListeleToolStripMenuItem.Text = "Ürün Listele(Güncelle ve Sil)";
            this.UrunListeleToolStripMenuItem.Click += new System.EventHandler(this.UrunListeleToolStripMenuItem_Click);
            // 
            // UrunResimEkleToolStripMenuItem
            // 
            this.UrunResimEkleToolStripMenuItem.Name = "UrunResimEkleToolStripMenuItem";
            this.UrunResimEkleToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.UrunResimEkleToolStripMenuItem.Text = "Ürün Resim Ekle";
            this.UrunResimEkleToolStripMenuItem.Click += new System.EventHandler(this.UrunResimEkleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "BAYNET ÜRÜN TAKİP SİSTEMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyrights © 2022 By Ali Baydur.";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1040, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ürün Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altKategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunResimEkleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

