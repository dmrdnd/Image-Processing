using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private Image geri;
        PictureBox picturebox = new PictureBox();

        public Form1()
        {

            InitializeComponent();
            genislik.Visible = false;
            yukseklik.Visible = false;
           
            text.Visible = false;

        }


        private void dosyaSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları|" + "*.bmp;*.jmp;*.gif;*.wmf;*.tif;*.png;*.jpg;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                

            }
        }


        private void Red_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
                Bitmap asil = new Bitmap(openFileDialog1.FileName);
                Metodlar redmode = new Metodlar();
                geri = pictureBox1.Image;
                pictureBox1.Image = redmode.RedMode(asil);
            }
        }

        private void Histogram(ArrayList pixel)
         {
            geri = pictureBox1.Image;
            //Bitmap bmp = new Bitmap(pictureBox1.Image);

            int[] dpixelsayisi = new int[256];

            for (int a = 0; a < 255; a++)  ///256 tane renk tonu için dönecek
            {
                int pixelsayisi = 0;
                for (int b = 0; b < pixel.Count; b++)
                {
                    if (a == Convert.ToInt16(pixel[b]))
                        pixelsayisi++;
                }
                dpixelsayisi[a] = pixelsayisi;
            }

            int renkmaxpixsayi = 0;  //grafikte y eksenini ölçeklerken kullanılacak
            for (int k = 0; k <= 255; k++)
            {
                if (dpixelsayisi[k] > renkmaxpixsayi)
                {
                    renkmaxpixsayi = dpixelsayisi[k];
                }
            }

            ///////grafiğin çizilmesi///////////
            Graphics cizim;
            Pen pencil1 = new Pen(System.Drawing.Color.Crimson, 1);
           cizim = RGBiHistogram.CreateGraphics();
            RGBiHistogram.Refresh();   ///grafikteki bilgilerin güncellenmesi

            int grafikyuksekligi = 200;
            double olcekY = renkmaxpixsayi / grafikyuksekligi, olcekX = 1.0;
            for (int m = 0; m <= 255; m++)
            {
                cizim.DrawLine(pencil1, (int)(m * olcekX), grafikyuksekligi, (int)(m * olcekX), (grafikyuksekligi - (int)(dpixelsayisi[m] / olcekY)));
                
            }
          
         }
            
 
        private void Green_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
               Bitmap asil = new Bitmap(openFileDialog1.FileName);
               Metodlar greenmode = new Metodlar();
                geri = pictureBox1.Image;
                pictureBox1.Image = greenmode.GreenMode(asil);

            }
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
               Bitmap asil = new Bitmap(openFileDialog1.FileName);
               Metodlar bluemode = new Metodlar();
                geri = pictureBox1.Image;
                pictureBox1.Image = bluemode.BlueMode(asil);

            }
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
                Bitmap asil = new Bitmap(openFileDialog1.FileName);
                Metodlar gri = new Metodlar();
                geri = pictureBox1.Image;
                pictureBox1.Image = gri.GriYap(asil);
            }
        }

        private void GrayHistogram_Click(object sender, EventArgs e)
        {
         
            Bitmap asil = new Bitmap(openFileDialog1.FileName);
            ArrayList pixel = new ArrayList();
            text.Visible = true;
            text.Text = "Gri Hİstogram";
            text.BackColor = Color.Gray;          

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
                int ortrenk = 0;
                Color renk;

                int i, j;
                /////image gri tona dönderilir////////
                for (i = 0; i < asil.Width; i++)
                {
                    for (j = 0; j < asil.Height; j++)
                    {
                        renk = asil.GetPixel(i, j);
                         ortrenk = (int)(renk.R + renk.G + renk.B) / 3;  //resmin gri tonu oluşturulur
                        pixel.Add(ortrenk);   //resimin tüm noktaları diziye atılıyor                     
        
                    }
                }
             Histogram(pixel);
            }
        }
      

        private void Negative_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
                Bitmap asil = new Bitmap(openFileDialog1.FileName);
                Metodlar negatif = new Metodlar();
                geri = pictureBox1.Image;
               pictureBox1.Image = negatif.NegativeYap(asil);
            }
        }

        private void Left_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                Metodlar ldondur = new Metodlar();
                geri = pictureBox1.Image;
                pictureBox1.Image = ldondur.LDondur(image);
            }
            
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                Metodlar rdondur = new Metodlar();
                geri = pictureBox1.Image;
                pictureBox1.Image = rdondur.RDondur(image);
            }
            
        }

        private void Mirror_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                Metodlar ayna = new Metodlar();
                geri = pictureBox1.Image;
                pictureBox1.Image = ayna.YatayAyna(image);
            }
        }



        public void TextBoxGiris()
        {

            String boyutx;
            String boyuty;
            int boyutx1, boyuty1;

            boyutx = genislik.Text;
            boyuty = yukseklik.Text;
                    
                boyutx1 = Convert.ToInt32(boyutx.ToString());
                boyuty1 = Convert.ToInt32(boyuty.ToString());

                Bitmap image = new Bitmap(pictureBox1.Image);
                Metodlar olcek = new Metodlar();
                pictureBox1.Image = olcek.Olceklendir(image, boyutx1, boyuty1);

        }

      

        private void OlcekGir_Click(object sender, EventArgs e)
        {
            genislik.Visible = true;
            yukseklik.Visible = true;  
        }


        private void Olceklendir_Click(object sender, EventArgs e)
        {
            text.Visible = false;
            genislik.Visible = false;
            yukseklik.Visible = false;
            String boyutx;
            String boyuty;
            int boyutx1, boyuty1;

            boyutx = genislik.Text;
            boyuty = yukseklik.Text;

            boyutx1 = Convert.ToInt32(boyutx.ToString());
            boyuty1 = Convert.ToInt32(boyuty.ToString());

            Bitmap image = new Bitmap(pictureBox1.Image);
            Metodlar olcek = new Metodlar();
            geri = pictureBox1.Image;
           RGBiHistogram.Image = olcek.Olceklendir(image, boyutx1, boyuty1);

        }

       
        private void Kayit_Click(object sender, EventArgs e)
        {

            SaveFileDialog kayit = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.
            kayit.Filter= "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.
            kayit.Title = "Kayıt"; //diyaloğun başlığı
            kayit.FileName = "Resim"; ///kaydedilen resmin adi 'resim'
            DialogResult sonuc = kayit.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                pictureBox1.Image.Save(kayit.FileName);   //Böylelikle resmi istediğimiz yere kaydediyoruz.
            }
           

        }


        private void sagAynala_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim Yüklenmedi!!");
            }
            else
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                Metodlar ayna = new Metodlar();
                pictureBox1.Image = ayna.SagAyna(image);
            }
            
        }

       
        private void KirmiziHistogram_Click(object sender, EventArgs e)
        {
            Bitmap asil = new Bitmap(openFileDialog1.FileName);
            ArrayList pixel = new ArrayList();
            text.Visible = true;
            text.Text = "Kırmızı Histogram";
            text.BackColor = Color.Red;

            Color renk;
            int i, j;

            for (i = 0; i < asil.Width; i++)
            {
                for (j = 0; j < asil.Height; j++)
                {
                    renk = asil.GetPixel(i, j);
                    int r = renk.R;
                    pixel.Add(r); //resimin tüm noktaları diziye atılıyor
                }
            }
            geri = pictureBox1.Image;
            Histogram(pixel);
        }

        private void YesilHistogram_Click(object sender, EventArgs e)
        {
            text.Visible = true;
            text.Text = "Yeşil Histogram";
            text.BackColor = Color.Green;
            Bitmap asil = new Bitmap(openFileDialog1.FileName);
            ArrayList pixel = new ArrayList();
            Color renk;

            int i, j;

            for (i = 0; i < asil.Width; i++)
            {
                for (j = 0; j < asil.Height; j++)
                {
                    renk = asil.GetPixel(i, j);
                    int g = renk.G;
                    pixel.Add(g); //resimin tüm noktaları diziye atılıyor
                }
            }
            geri = pictureBox1.Image;
            Histogram(pixel);
        }

        private void MaviHistogram_Click(object sender, EventArgs e)
        {
            text.Visible = true;
            text.Text = "Mavi Histogram";
            text.BackColor = Color.Blue;
            Bitmap asil = new Bitmap(openFileDialog1.FileName);
            ArrayList pixel = new ArrayList();
            Color renk;
            int i, j;

            for (i = 0; i < asil.Width; i++)
            {
                for (j = 0; j < asil.Height; j++)
                {
                    renk = asil.GetPixel(i, j);
                    int b = renk.B;
                    pixel.Add(b); //resimin tüm noktaları diziye atılıyor
                }
            }
            geri = pictureBox1.Image;
            Histogram(pixel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = geri;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}