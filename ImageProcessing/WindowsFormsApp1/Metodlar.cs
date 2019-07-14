using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;


namespace WindowsFormsApp1
{
    class Metodlar
    {
        public Bitmap GriYap(Bitmap bmp)
        {

            int i, j;
            Color renk;
            //iç içe for döngüleri ile görüntü üzerine pixel pixel dolaşılacak
            for (i = 0; i < bmp.Height; i++)
            {
                for (j = 0; j < bmp.Width; j++)
                {
                    renk = bmp.GetPixel(j, i);

                    int a = renk.A;
                    int b = renk.B;
                    int r = renk.R;
                    int g = renk.G;

                    int ort = (r + g + b) / 3;
                    bmp.SetPixel(j, i, Color.FromArgb(a, ort, ort, ort));
                }
            }
            return bmp;
        }


        /*********************************************************************************************************/



        public Bitmap RedMode(Bitmap bmp)
        {
          
           int i, j;
            Color renk;
            for (i = 0; i < bmp.Height; i++)
            {
                for (j = 0; j < bmp.Width; j++)
                {
                    renk = bmp.GetPixel(j, i);
                    int a = renk.A;
                    int b = renk.B;
                    int r = renk.R;
                    int g = renk.G;

                    bmp.SetPixel(j, i, Color.FromArgb(a, r, 0, 0));
                }
            }
            return bmp;
        }

      

        public Bitmap GreenMode(Bitmap bmp)
        {
            

            int i, j;
            Color renk;
            for (i = 0; i < bmp.Height; i++)
            {
                for (j = 0; j < bmp.Width; j++)
                {
                    renk = bmp.GetPixel(j, i);
                    int a = renk.A;
                    int b = renk.B;
                    int r = renk.R;
                    int g = renk.G;

                    bmp.SetPixel(j, i, Color.FromArgb(a, 0, g, 0));

                }
            }
            return bmp;

        }
        /*********************************************************************************************************/

        public Bitmap BlueMode(Bitmap bmp)
        {

          
            int i, j;
            Color renk;
            for (i = 0; i < bmp.Height; i++)
            {
                for (j = 0; j < bmp.Width; j++)
                {
                    renk = bmp.GetPixel(j, i);
                    int a = renk.A;
                    int b = renk.B;
                    int r = renk.R;
                    int g = renk.G;

                    bmp.SetPixel(j, i, Color.FromArgb(a, 0, 0, b));
                }
            }
            return bmp;
        }
        public Bitmap LDondur(Bitmap bmp)
        {
            int i, j;
            Bitmap returnbmp = new Bitmap(bmp.Height, bmp.Width);
            for (i = 0; i < bmp.Width; i++)
            {
                for (j = 0; j < bmp.Height; j++)
                {
                    returnbmp.SetPixel(j, returnbmp.Height - 1 - i, bmp.GetPixel(i, j));
                }
            }
            return returnbmp;
        }

        /**********************************************************************************************************/

        public Bitmap RDondur(Bitmap bmp)
        {
            int i, j;
            Bitmap returnbmp = new Bitmap(bmp.Height, bmp.Width);
            for (i = 0; i < bmp.Width; i++)
            {
                for (j = 0; j < bmp.Height; j++)
                {
                    returnbmp.SetPixel(returnbmp.Width - j - 1, i, bmp.GetPixel(i, j));
                }
            }
            return returnbmp;
        }

        public Bitmap YatayAyna(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Width - i - 1, j, bmp.GetPixel(i, j));
                }
            }
            return b;
        }

       
        public Bitmap SagAyna(Bitmap bmp)
        {
            Bitmap b = new Bitmap(bmp.Width, bmp.Height);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    b.SetPixel(b.Height- j - 1, i, bmp.GetPixel(j, i));
                }
            }
            return b;
        }

     

        /***********************************************************************************************************
                    ********************************************************************************************************/

        public Bitmap NegativeYap(Bitmap bmp)
        {

            int i, j;
            Color renk;
            for (i = 0; i < bmp.Height; i++)
            {
                for (j = 0; j < bmp.Width; j++)
                {
                    //pixel degerleri
                    renk = bmp.GetPixel(j, i);
                    int a = renk.A;
                    int r = renk.R;
                    int g = renk.G;
                    int b = renk.B;

                    //negatif degerleri
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    //ARGB degerlerini pixellere ata
                    bmp.SetPixel(j, i, Color.FromArgb(a, r, g, b));
                }
            }


            return bmp;
        }

        /***********************************************************************************************************
                    ********************************************************************************************************/

        public Bitmap Olceklendir(Bitmap bmp, int newXSize, int newYSize)
        {
            Bitmap newBMP = new Bitmap(newXSize, newYSize);

            int[] temp = new int[newXSize * newYSize];
            int x, y;
            Color A, B, C, D;
            float x_oran = ((float)(bmp.Width - 1)) / newXSize;
            float y_oran = ((float)(bmp.Height - 1)) / newYSize;

            float w, h;

            for (int i = 0; i < newYSize; i++)
            {
                for (int j = 0; j < newXSize; j++)
                {
                    x = (int)(x_oran * j);
                    y = (int)(y_oran * i);
                    w = (x_oran * j) - x;
                    h = (y_oran * i) - y;

                    A = bmp.GetPixel(x, y);
                    B = bmp.GetPixel(x + 1, y);
                    C = bmp.GetPixel(x, y + 1);
                    D = bmp.GetPixel(x + 1, y + 1);

                    //  int r = (int)(A.R * (1 - w) * (1 - h) + B.R * (w) * (1 - h) + C.R * (h) * (1 - w) + D.R * (w * h));
                    // int g = (int)(A.G * (1 - w) * (1 - h) + B.G * (w) * (1 - h) + C.G * (h) * (1 - w) + D.G * (w * h));
                    // int b = (int)(A.B * (1 - w) * (1 - h) + B.B * (w) * (1 - h) + C.B * (h) * (1 - w) + D.B * (w * h));

                    int r = A.R;
                    int g = A.G;
                    int b = A.B;
                    Color col = Color.FromArgb(r, g, b);

                    newBMP.SetPixel(j, i, col);
                }
            }

            return newBMP;
        }


        /************************************************************************************************************************************/


    }


}
