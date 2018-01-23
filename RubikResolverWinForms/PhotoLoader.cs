using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RubikResolverEngine;

namespace RubikResolverWinForms
{
    public partial class PhotoLoader : Form
    {
        public PhotoLoader()
        {
            InitializeComponent();
        }

        #region control events
        /// <summary>
        /// załaduj 1 zdjęcie 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image1Btn_Click(object sender, EventArgs e)
        {
            LoadImageFile(1);
        }
        private void Image3Btn_Click(object sender, EventArgs e)
        {
            LoadImageFile(3);
        }

        private void Image2Btn_Click(object sender, EventArgs e)
        {
            LoadImageFile(2);
        }

        private void Image4Btn_Click(object sender, EventArgs e)
        {
            LoadImageFile(4);
        }

        private void Image5Btn_Click(object sender, EventArgs e)
        {
            LoadImageFile(5);
        }

        private void Image6Btn_Click(object sender, EventArgs e)
        {
            LoadImageFile(6);
        }
        #endregion

        /// <summary>
        /// funkcja uniwersalna do ładowania obrazków
        /// </summary>
        /// <param name="faceNo"></param>
        private void LoadImageFile(int faceNo)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files|*.jpg;*.jpeg;*.png;"; // "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = @"C:\Users\Karlik\Documents\programowanie\RubikSolver\RubikSolver\img\";
            dialog.Title = "Wybierz zdjęcie kostki (płaszczyzna nr " + faceNo + ")";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = (Bitmap)Image.FromFile(dialog.FileName, true);
                //img.GetPixel(100, 100);
                var colorRecognizer = new ColorRecognizer(img);
                var surface = colorRecognizer.Recognize();


                //test
                //surface.SetColor(0, 0, Color.Red);
                //surface.SetColor(0, 1, Color.Yellow);
                //surface.SetColor(0, 2, Color.White);
                //surface.SetColor(1, 0, Color.Green);
                //surface.SetColor(1, 1, Color.Green);
                //surface.SetColor(1, 2, Color.Red);
                //surface.SetColor(2, 0, Color.Red);
                //surface.SetColor(2, 1, Color.Blue);
                //surface.SetColor(2, 2, Color.Orange);

                //odrysuj surface na obrazku
                if (faceNo == 1)
                {
                    surface.DrawFace(Face1PictureBox.CreateGraphics(), Face1PictureBox.Width);
                    //DrawFace(surface, Face1PictureBox);
                }
                else if (faceNo == 2)
                {
                    surface.DrawFace(Face2PictureBox.CreateGraphics(), Face2PictureBox.Width);
                }
                else if (faceNo == 3)
                {
                    surface.DrawFace(Face3PictureBox.CreateGraphics(), Face3PictureBox.Width);
                }
                else if (faceNo == 4)
                {
                    surface.DrawFace(Face4PictureBox.CreateGraphics(), Face4PictureBox.Width);
                }
                else if (faceNo == 5)
                {
                    surface.DrawFace(Face5PictureBox.CreateGraphics(), Face5PictureBox.Width);
                }
                else if (faceNo == 6)
                {
                    surface.DrawFace(Face6PictureBox.CreateGraphics(), Face6PictureBox.Width);
                }
            }
        }

        ///// <summary>
        ///// odrysowuje ścianę kostki (po rozpoznaniu) na przekazanej kontrolce PictureBox
        ///// </summary>
        ///// <param name="surface"></param>
        ///// <param name="pictureBox"></param>
        //private void DrawFace(Surface surface, PictureBox pictureBox)
        //{
        //    try
        //    {
        //        Graphics g = pictureBox.CreateGraphics();

        //        Rectangle ee = new Rectangle(10, 10, 30, 30);
        //        using (Pen pen = new Pen(Color.Red, 2))
        //        {
        //            g.DrawRectangle(pen, ee);
        //            //e.Graphics.DrawRectangle(pen, ee);
        //        }
        //    }
        //    catch (RubikException ex)
        //    {

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

       
    }
}
