using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaSecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Left = new System.Windows.Forms.ToolStripMenuItem();
            this.Right = new System.Windows.Forms.ToolStripMenuItem();
            this.Mirror = new System.Windows.Forms.ToolStripMenuItem();
            this.sagAynala = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Red = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.Gray = new System.Windows.Forms.ToolStripMenuItem();
            this.Negative = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GriyHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.KirmiziHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.YesilHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.MaviHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.OlcekGir = new System.Windows.Forms.ToolStripMenuItem();
            this.Olceklendir = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.genislik = new System.Windows.Forms.TextBox();
            this.yukseklik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Kayit = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fhdhjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RGBiHistogram = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBiHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaSecToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.histogramToolStripMenuItem1,
            this.OlcekGir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 47);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaSecToolStripMenuItem
            // 
            this.dosyaSecToolStripMenuItem.AutoSize = false;
            this.dosyaSecToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dosyaSecToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dosyaSecToolStripMenuItem.Image = global::yazılım_lab.Properties.Resources.image_documents_icon;
            this.dosyaSecToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dosyaSecToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dosyaSecToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.dosyaSecToolStripMenuItem.Name = "dosyaSecToolStripMenuItem";
            this.dosyaSecToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.dosyaSecToolStripMenuItem.Size = new System.Drawing.Size(35, 35);
            this.dosyaSecToolStripMenuItem.ToolTipText = "Dosya Seç";
            this.dosyaSecToolStripMenuItem.Click += new System.EventHandler(this.dosyaSecToolStripMenuItem_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.AutoSize = false;
            this.görünümToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.görünümToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Left,
            this.Right,
            this.Mirror,
            this.sagAynala});
            this.görünümToolStripMenuItem.Image = global::yazılım_lab.Properties.Resources.arrow_refresh_4_icon;
            this.görünümToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.görünümToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.görünümToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.görünümToolStripMenuItem.MergeIndex = 0;
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(35, 35);
            this.görünümToolStripMenuItem.ToolTipText = "Görünüm";
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(171, 26);
            this.Left.Text = "Sola Dönder";
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.DarkKhaki;
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(171, 26);
            this.Right.Text = "Sağa Dönder";
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Mirror
            // 
            this.Mirror.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(171, 26);
            this.Mirror.Text = "Sol Aynala";
            this.Mirror.Click += new System.EventHandler(this.Mirror_Click);
            // 
            // sagAynala
            // 
            this.sagAynala.BackColor = System.Drawing.Color.DarkKhaki;
            this.sagAynala.Name = "sagAynala";
            this.sagAynala.Size = new System.Drawing.Size(171, 26);
            this.sagAynala.Text = "Sağ Aynala";
            this.sagAynala.Click += new System.EventHandler(this.sagAynala_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.AutoSize = false;
            this.histogramToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.histogramToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Red,
            this.greenToolStripMenuItem,
            this.Blue,
            this.Gray,
            this.Negative});
            this.histogramToolStripMenuItem.Image = global::yazılım_lab.Properties.Resources.colors_icon__1_;
            this.histogramToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.histogramToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.histogramToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.histogramToolStripMenuItem.MergeIndex = 0;
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(35, 35);
            this.histogramToolStripMenuItem.ToolTipText = "Renk Tonları";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.ImageTransparentColor = System.Drawing.Color.Red;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(169, 26);
            this.Red.Text = "Kırmızı Mod";
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.greenToolStripMenuItem.Text = "Yeşil Mod";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.Green_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(169, 26);
            this.Blue.Text = "Mavi Mod";
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.LightGray;
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(169, 26);
            this.Gray.Text = "Gri Mod";
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // Negative
            // 
            this.Negative.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(169, 26);
            this.Negative.Text = "Negatif Mod";
            this.Negative.Click += new System.EventHandler(this.Negative_Click);
            // 
            // histogramToolStripMenuItem1
            // 
            this.histogramToolStripMenuItem1.AutoSize = false;
            this.histogramToolStripMenuItem1.AutoToolTip = true;
            this.histogramToolStripMenuItem1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.histogramToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.histogramToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GriyHistogram,
            this.KirmiziHistogram,
            this.YesilHistogram,
            this.MaviHistogram});
            this.histogramToolStripMenuItem1.Image = global::yazılım_lab.Properties.Resources.Actions_view_object_histogram_logarithmic_icon;
            this.histogramToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.histogramToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.histogramToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(4);
            this.histogramToolStripMenuItem1.MergeIndex = 0;
            this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            this.histogramToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(35, 35);
            this.histogramToolStripMenuItem1.ToolTipText = "Histogram";
            // 
            // GriyHistogram
            // 
            this.GriyHistogram.BackColor = System.Drawing.Color.LightGray;
            this.GriyHistogram.Name = "GriyHistogram";
            this.GriyHistogram.Size = new System.Drawing.Size(204, 26);
            this.GriyHistogram.Text = "Gri Histogram";
            this.GriyHistogram.Click += new System.EventHandler(this.GrayHistogram_Click);
            // 
            // KirmiziHistogram
            // 
            this.KirmiziHistogram.BackColor = System.Drawing.Color.Red;
            this.KirmiziHistogram.Name = "KirmiziHistogram";
            this.KirmiziHistogram.Size = new System.Drawing.Size(204, 26);
            this.KirmiziHistogram.Text = "Kırmızı Histogram";
            this.KirmiziHistogram.Click += new System.EventHandler(this.KirmiziHistogram_Click);
            // 
            // YesilHistogram
            // 
            this.YesilHistogram.BackColor = System.Drawing.Color.LawnGreen;
            this.YesilHistogram.Name = "YesilHistogram";
            this.YesilHistogram.Size = new System.Drawing.Size(204, 26);
            this.YesilHistogram.Text = "Yeşil Histogram";
            this.YesilHistogram.Click += new System.EventHandler(this.YesilHistogram_Click);
            // 
            // MaviHistogram
            // 
            this.MaviHistogram.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MaviHistogram.Name = "MaviHistogram";
            this.MaviHistogram.Size = new System.Drawing.Size(204, 26);
            this.MaviHistogram.Text = "Mavi Histogram";
            this.MaviHistogram.Click += new System.EventHandler(this.MaviHistogram_Click);
            // 
            // OlcekGir
            // 
            this.OlcekGir.AutoSize = false;
            this.OlcekGir.AutoToolTip = true;
            this.OlcekGir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.OlcekGir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OlcekGir.Checked = true;
            this.OlcekGir.CheckOnClick = true;
            this.OlcekGir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OlcekGir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Olceklendir});
            this.OlcekGir.Image = global::yazılım_lab.Properties.Resources.Search_icon;
            this.OlcekGir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OlcekGir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OlcekGir.Margin = new System.Windows.Forms.Padding(4);
            this.OlcekGir.Name = "OlcekGir";
            this.OlcekGir.Size = new System.Drawing.Size(35, 35);
            this.OlcekGir.ToolTipText = "Ölçek Gir";
            this.OlcekGir.Click += new System.EventHandler(this.OlcekGir_Click);
            // 
            // Olceklendir
            // 
            this.Olceklendir.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Olceklendir.Name = "Olceklendir";
            this.Olceklendir.Size = new System.Drawing.Size(159, 26);
            this.Olceklendir.Text = "Olceklendir";
            this.Olceklendir.Click += new System.EventHandler(this.Olceklendir_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "image.png");
            this.ımageList1.Images.SetKeyName(1, "image.ico");
            this.ımageList1.Images.SetKeyName(2, "zoom-icon.png");
            this.ımageList1.Images.SetKeyName(3, "Go-back-icon.png");
            this.ımageList1.Images.SetKeyName(4, "Go-back-icon (1).png");
            this.ımageList1.Images.SetKeyName(5, "Save-icon (1).png");
            // 
            // genislik
            // 
            this.genislik.Location = new System.Drawing.Point(318, 2);
            this.genislik.Name = "genislik";
            this.genislik.Size = new System.Drawing.Size(50, 22);
            this.genislik.TabIndex = 31;
            this.toolTip1.SetToolTip(this.genislik, "Genişlik");
            // 
            // yukseklik
            // 
            this.yukseklik.Location = new System.Drawing.Point(318, 30);
            this.yukseklik.Name = "yukseklik";
            this.yukseklik.Size = new System.Drawing.Size(50, 22);
            this.yukseklik.TabIndex = 32;
            this.toolTip1.SetToolTip(this.yukseklik, "Yükseklik");
            // 
            // button1
            // 
            this.button1.Image = global::yazılım_lab.Properties.Resources.Go_back_icon__1_;
            this.button1.Location = new System.Drawing.Point(880, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 40;
            this.toolTip1.SetToolTip(this.button1, "Geri");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kayit
            // 
            this.Kayit.Image = ((System.Drawing.Image)(resources.GetObject("Kayit.Image")));
            this.Kayit.Location = new System.Drawing.Point(880, 59);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(35, 35);
            this.Kayit.TabIndex = 33;
            this.toolTip1.SetToolTip(this.Kayit, "Kaydet");
            this.Kayit.UseVisualStyleBackColor = true;
            this.Kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Beige;
            this.text.Location = new System.Drawing.Point(576, 473);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(236, 22);
            this.text.TabIndex = 39;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fhdhjToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 28);
            // 
            // fhdhjToolStripMenuItem
            // 
            this.fhdhjToolStripMenuItem.Name = "fhdhjToolStripMenuItem";
            this.fhdhjToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.fhdhjToolStripMenuItem.Text = "fhdhj";
            // 
            // RGBiHistogram
            // 
            this.RGBiHistogram.BackColor = System.Drawing.Color.Beige;
            this.RGBiHistogram.Location = new System.Drawing.Point(554, 216);
            this.RGBiHistogram.Name = "RGBiHistogram";
            this.RGBiHistogram.Size = new System.Drawing.Size(361, 264);
            this.RGBiHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RGBiHistogram.TabIndex = 6;
            this.RGBiHistogram.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 549);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(938, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Kayit);
            this.Controls.Add(this.yukseklik);
            this.Controls.Add(this.genislik);
            this.Controls.Add(this.RGBiHistogram);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "İmage Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGBiHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


      

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox RGBiHistogram;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Red;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Blue;
        private System.Windows.Forms.ToolStripMenuItem Gray;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GriyHistogram;
        private System.Windows.Forms.ToolStripMenuItem KirmiziHistogram;
        private System.Windows.Forms.ToolStripMenuItem YesilHistogram;
        private System.Windows.Forms.ToolStripMenuItem MaviHistogram;
        private System.Windows.Forms.ToolStripMenuItem Negative;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox genislik;
        private System.Windows.Forms.TextBox yukseklik;
        private System.Windows.Forms.ToolStripMenuItem Olceklendir;
        private System.Windows.Forms.ToolStripMenuItem dosyaSecToolStripMenuItem;
        private System.Windows.Forms.Button Kayit;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Left;
        private System.Windows.Forms.ToolStripMenuItem Right;
        private System.Windows.Forms.ToolStripMenuItem Mirror;
        private System.Windows.Forms.ToolStripMenuItem sagAynala;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ToolStripMenuItem OlcekGir;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fhdhjToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

