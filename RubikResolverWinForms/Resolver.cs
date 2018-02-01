using RubikResolverEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubikResolverWinForms
{
    public partial class Resolver : Form
    {
        Cube _cube = null;

        public Resolver()
        {
            InitializeComponent();
        }

        /// <summary>
        /// rysuje całą kostkę
        /// </summary>
        public void DrawCube()
        {
            try
            {
                var surfList = _cube.GetSurfaces();

                //foreach (Surface surface in surfList)
                for (int i = 0; i < 6; i++)
                {
                    DrawFace(surfList[i], i + 1);
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
                //var surfTmp = new Surface(faceNo);
                //surfTmp.SetColors(surface.GetColors());
                //_surfList[faceNo - 1] = surfTmp;

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

        #region repaint picture boxes
        private void Face2PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_cube.GetSurface(2) != null)
                DrawFace(_cube.GetSurface(2), 2);
        }

        private void Face3PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_cube.GetSurface(3) != null)
                DrawFace(_cube.GetSurface(3), 3);
        }

        private void Face4PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_cube.GetSurface(4) != null)
                DrawFace(_cube.GetSurface(4), 4);
        }

        private void Face5PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_cube.GetSurface(5) != null)
                DrawFace(_cube.GetSurface(5), 5);
        }

        private void Face6PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_cube.GetSurface(6) != null)
                DrawFace(_cube.GetSurface(6), 6);
        }
        
        private void Face1PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (_cube.GetSurface(1) != null)
            {
                DrawFace(_cube.GetSurface(1), 1);
                //Face1PictureBox.Invalidate();
            }
        }
        #endregion

        private void UpdateMoveCount()
        {

        }

        /// <summary>
        /// wymyśl ruchy i je wygneruj
        /// </summary>
        /// <param name="cube"></param>
        public void Resolve(Cube cube)
        {
            this._cube = cube;
            //todo: rozwiązywanie...

            //test
            List<Move> moves = new List<RubikResolverEngine.Move>();
            moves.Add(new RubikResolverEngine.Move(4, false));
            this._cube.Move(Face4PictureBox.CreateGraphics(), moves[0]);
            //koniec test

            //DrawCube();
        }

        /// <summary>
        /// nadpisanie zdarzenia Show
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            //todo: pokaż kroki rozwiązania
           
            base.OnShown(e);
        }

        /// <summary>
        /// odrysowanie całej formatki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resolver_Paint(object sender, PaintEventArgs e)
        {
            var _surfList = _cube.GetSurfaces();
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

            //test
            List<Move> moves = new List<RubikResolverEngine.Move>();
            moves.Add(new RubikResolverEngine.Move(4, false));
            this._cube.PaintMove(Face4PictureBox.CreateGraphics(), moves[0]);
            //koniec test
        }
    }
}
