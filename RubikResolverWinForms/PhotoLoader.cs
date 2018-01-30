using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RubikResolverEngine;
using System.IO;

namespace RubikResolverWinForms
{
    public partial class PhotoLoader : Form
    {
        //private List<Surface> _surfList = null;
        private Surface[] _surfList = null;
        int _XcontextMenu, _YcontextMenu;
        int _faceNoContextMenu;
        PictureBox _pictureBoxContexyMenu;

        public PhotoLoader()
        {
            InitializeComponent();
            //_surfList = new List<Surface>(6);
            _surfList = new Surface[6];
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_surfList[0] != null)
                DrawFace(_surfList[0], 1);
            if (_surfList[1] != null)
                DrawFace(_surfList[1], 2);
            if (_surfList[2] != null)
                DrawFace(_surfList[2], 3);
            if (_surfList[3] != null)
                DrawFace(_surfList[3], 4);
            if (_surfList[4] != null)
                DrawFace(_surfList[4], 5);
            if (_surfList[5] != null)
                DrawFace(_surfList[5], 6);

            base.OnPaint(e);
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
                
                //uruchom rysowanie
                DrawFace(surface, faceNo);

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
                
                
            }
        }

        /// <summary>
        /// odrysowuje przekazany surface na danej kostce
        /// </summary>
        /// <param name="surface"></param>
        /// <param name="faceNo"></param>
        private void DrawFace(Surface surface, int faceNo)
        {
            try
            {
                if (surface == null)
                    throw new RubikException("DrawFace - surface nie może być null");
                if (faceNo < 0 || faceNo > 6)
                    throw new RubikException("DrawFace - podano nieprawidłowy argument faceNo: " + faceNo);

                //wpisz do globalnej tablicy, żeby potem móc zapisać/wczytać rzopoznane ścianki kostki
                var surfTmp = new Surface();
                surfTmp.SetColors(surface.GetColors());
                _surfList[faceNo - 1] = surfTmp;

                if (faceNo == 1)
                {
                    surface.DrawFace(Face1PictureBox.CreateGraphics(), Face1PictureBox.Width);
                    //Face1PictureBox.Invalidate();
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
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }
        
        /// <summary>
        /// wczytaj plik z rozpoznanymi kwadratami
        /// </summary>
        /// <param name="fileName"></param>
        public void OpenFaceFile(string fileName)
        {
            try
            {
                var lines = File.ReadAllLines(fileName);
                int count = 1;

                foreach (string line in lines)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        var splited = line.Split(';');

                        Surface surface = new Surface();
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                string colorStr = splited[3 * i + j];
                                if (colorStr == "red")
                                    surface.SetColor(i, j, Color.Red);
                                else if (colorStr == "orange")
                                    surface.SetColor(i, j, Color.Orange);
                                else if (colorStr == "yellow")
                                    surface.SetColor(i, j, Color.Yellow);
                                else if (colorStr == "blue")
                                    surface.SetColor(i, j, Color.Blue);
                                else if (colorStr == "green")
                                    surface.SetColor(i, j, Color.Green);
                                else if (colorStr == "white")
                                    surface.SetColor(i, j, Color.White);
                                else
                                    surface.SetColor(i, j, Color.Black);
                            }
                        }

                        _surfList[count - 1] = surface;
                        DrawFace(surface, count);
                    }

                    count++;
                }
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// zapisuje wczytane zdjęcia (listę surface) do pliku
        /// </summary>
        /// <param name="fileName"></param>
        public void SaveFacesToFile(string fileName)
        {
            try
            {
                string content = "";
                
                for(int i = 0; i < 6; i++)
                {
                    if (_surfList[i] == null)
                    {
                        content += Environment.NewLine;
                    }
                    else
                    {
                        string line = "";

                        for(int x = 0; x < 3; x++)
                        {
                            for(int y = 0; y < 3; y++)
                            {
                                var color = _surfList[i].GetColor(x, y);

                                if (color.R == Color.Red.R && color.G == Color.Red.G && color.B == Color.Red.B)
                                    line += "red;";
                                else if (color.R == Color.Blue.R && color.G == Color.Blue.G && color.B == Color.Blue.B)
                                    line += "blue;";
                                else if (color.R == Color.Green.R && color.G == Color.Green.G && color.B == Color.Green.B)
                                    line += "green;";
                                else if (color.R == Color.Yellow.R && color.G == Color.Yellow.G && color.B == Color.Yellow.B)
                                    line += "yellow;";
                                else if (color.R == Color.Orange.R && color.G == Color.Orange.G && color.B == Color.Orange.B)
                                    line += "orange;";
                                else if (color.R == Color.White.R && color.G == Color.White.G && color.B == Color.White.B)
                                    line += "white;";
                                else
                                    line += "black;";
                            }
                        }

                        content += line + Environment.NewLine;
                    }
                }

                File.WriteAllText(fileName, content);
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }

        #region menu kontekstowe
        /// <summary>
        /// pokaż menu kontekstowe
        /// </summary>
        /// <param name="faceNo"></param>
        /// <param name="pictureBox"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void ShowContextMenu(int faceNo, PictureBox pictureBox, int x, int y)
        {
            _XcontextMenu = x;
            _YcontextMenu = y;
            _faceNoContextMenu = faceNo;
            _pictureBoxContexyMenu = pictureBox;
            ColorsContextMenu.Show(pictureBox, x, y);
        }

        /// <summary>
        /// kliknięcie na picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Face1PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = (PictureBox)sender;
                ShowContextMenu(1, pictureBox, e.X, e.Y);
            }
        }

        private void Face2PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = (PictureBox)sender;
                ShowContextMenu(2, pictureBox, e.X, e.Y);
            }
        }

        private void Face3PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = (PictureBox)sender;
                ShowContextMenu(3, pictureBox, e.X, e.Y);
            }
        }

        private void Face4PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = (PictureBox)sender;
                //ColorsContextMenu.Show(e.X, e.Y);
                ShowContextMenu(4, pictureBox, e.X, e.Y);
            }
        }

        private void Face5PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = (PictureBox)sender;
                ShowContextMenu(5, pictureBox, e.X, e.Y);
            }
        }
        
        private void Face6PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox pictureBox = (PictureBox)sender;
                ShowContextMenu(6, pictureBox, e.X, e.Y);
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawOneColor(Color.Blue);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawOneColor(Color.Green);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawOneColor(Color.Yellow);
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawOneColor(Color.Orange);
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawOneColor(Color.White);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawOneColor(Color.Red);
        }
        
        /// <summary>
        /// pokoloruj jeden mały kwadracik na wybrany kolor
        /// </summary>
        /// <param name="color"></param>
        private void DrawOneColor(Color color)
        {
            try
            {
                int y = _XcontextMenu / (_pictureBoxContexyMenu.Width / 3);
                int x = _YcontextMenu / (_pictureBoxContexyMenu.Height / 3);

                if (_surfList[_faceNoContextMenu -1] == null)
                    _surfList[_faceNoContextMenu -1] = new Surface();

                _surfList[_faceNoContextMenu - 1].SetColor(x, y, color);
                _surfList[_faceNoContextMenu - 1].DrawFace(_pictureBoxContexyMenu.CreateGraphics(), _pictureBoxContexyMenu.Width);
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region repaint picture boxes
        private void Face2PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_surfList[1] != null)
                DrawFace(_surfList[1], 2);
        }

        private void Face3PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_surfList[2] != null)
                DrawFace(_surfList[2], 3);
        }

        private void Face4PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_surfList[3] != null)
                DrawFace(_surfList[3], 4);
        }

        private void Face5PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_surfList[4] != null)
                DrawFace(_surfList[4], 5);
        }

        private void Face6PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_surfList[5] != null)
                DrawFace(_surfList[5], 6);
        }

        private void Face1PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_surfList[0] != null)
            {
                DrawFace(_surfList[0], 1);
                //Face1PictureBox.Invalidate();
            }
        }
        #endregion
    }
}
