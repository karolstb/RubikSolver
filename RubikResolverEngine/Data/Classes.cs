using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace RubikResolverEngine
{
    public class Surface
    {
        //public Color MyProperty { get; set; }
        private Color[,] colors { get; set; }
        int orderNumber;    //numer od 1 do 6 określa położenie surface na kostce

        public Surface(int orderNumber)
        {
            if (orderNumber < 1 || orderNumber > 6)
                throw new RubikException("Nieprawidłowy parametr orderNumber w konstuktorze Surface (" + orderNumber + ")");

            this.orderNumber = orderNumber;
            colors = new Color[3, 3];
        }

        /// <summary>
        /// zwraca współrzędne sąsiedniego bloku na innej płaszczyźnie
        /// </summary>
        /// <param name="edgeBlock"></param>
        /// <returns></returns>
        public Coordinate GetNeighbourEdgeBlock(EEdgeBlock edgeBlock)
        {
            switch (this.orderNumber)
            {
                case 1:
                    {
                        #region
                        switch (edgeBlock)
                        {
                            case EEdgeBlock.UpLeft:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.UpCenter:
                                {
                                    return new Coordinate(2,1);
                                }
                            case EEdgeBlock.UpRight:
                                {
                                    return new Coordinate(2,2);
                                }
                            case EEdgeBlock.RightUp:
                                {
                                    return new Coordinate(0,2);
                                }
                            case EEdgeBlock.RightCenter:
                                {
                                    return new Coordinate(0, 1);
                                }
                            case EEdgeBlock.RightDown:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.DownRight:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.DownCenter:
                                {
                                    return new Coordinate(0, 1);
                                }
                            case EEdgeBlock.DownLeft:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.LeftDown:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.LeftCenter:
                                {
                                    return new Coordinate(0, 1);
                                }
                            case EEdgeBlock.LeftUp:
                                {
                                    return new Coordinate(0, 0);
                                }
                        }
                        #endregion
                        break;
                    }
                case 2:
                    {
                        #region
                        switch (edgeBlock)
                        {
                            case EEdgeBlock.UpLeft:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.UpCenter:
                                {
                                    return new Coordinate(1, 0);
                                }
                            case EEdgeBlock.UpRight:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.RightUp:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.RightCenter:
                                {
                                    return new Coordinate(1, 0);
                                }
                            case EEdgeBlock.RightDown:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.DownRight:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.DownCenter:
                                {
                                    return new Coordinate(1, 0);
                                }
                            case EEdgeBlock.DownLeft:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.LeftDown:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.LeftCenter:
                                {
                                    return new Coordinate(1, 0);
                                }
                            case EEdgeBlock.LeftUp:
                                {
                                    return new Coordinate(2, 0);
                                }
                        }
                        #endregion
                        break; 
                    }
                case 3:
                    {
                        #region
                        switch (edgeBlock)
                        {
                            case EEdgeBlock.UpLeft:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.UpCenter:
                                {
                                    return new Coordinate(2, 1);
                                }
                            case EEdgeBlock.UpRight:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.RightUp:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.RightCenter:
                                {
                                    return new Coordinate(1, 0);
                                }
                            case EEdgeBlock.RightDown:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.DownRight:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.DownCenter:
                                {
                                    return new Coordinate(0, 1);
                                }
                            case EEdgeBlock.DownLeft:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.LeftDown:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.LeftCenter:
                                {
                                    return new Coordinate(1,2);
                                }
                            case EEdgeBlock.LeftUp:
                                {
                                    return new Coordinate(0, 2);
                                }
                        }
                        #endregion
                        break;
                    }
                case 4:
                    {
                        #region
                        switch (edgeBlock)
                        {
                            case EEdgeBlock.UpLeft:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.UpCenter:
                                {
                                    return new Coordinate(1, 2);
                                }
                            case EEdgeBlock.UpRight:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.RightUp:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.RightCenter:
                                {
                                    return new Coordinate(1, 2);
                                }
                            case EEdgeBlock.RightDown:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.DownRight:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.DownCenter:
                                {
                                    return new Coordinate(1, 2);
                                }
                            case EEdgeBlock.DownLeft:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.LeftDown:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.LeftCenter:
                                {
                                    return new Coordinate(1, 2);
                                }
                            case EEdgeBlock.LeftUp:
                                {
                                    return new Coordinate(0, 2);
                                }
                        }
                        #endregion
                        break;
                    }
                case 5:
                    {
                        #region
                        switch (edgeBlock)
                        {
                            case EEdgeBlock.UpLeft:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.UpCenter:
                                {
                                    return new Coordinate(2, 1);
                                }
                            case EEdgeBlock.UpRight:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.RightUp:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.RightCenter:
                                {
                                    return new Coordinate(2, 1);
                                }
                            case EEdgeBlock.RightDown:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.DownRight:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.DownCenter:
                                {
                                    return new Coordinate(0, 1);
                                }
                            case EEdgeBlock.DownLeft:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.LeftDown:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.LeftCenter:
                                {
                                    return new Coordinate(2, 1);
                                }
                            case EEdgeBlock.LeftUp:
                                {
                                    return new Coordinate(2, 2);
                                }
                        }
                        #endregion
                        break;
                    }
                case 6:
                    {
                        #region
                        switch (edgeBlock)
                        {
                            case EEdgeBlock.UpLeft:
                                {
                                    return new Coordinate(2, 0);
                                }
                            case EEdgeBlock.UpCenter:
                                {
                                    return new Coordinate(2, 1);
                                }
                            case EEdgeBlock.UpRight:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.RightUp:
                                {
                                    return new Coordinate(2, 2);
                                }
                            case EEdgeBlock.RightCenter:
                                {
                                    return new Coordinate(1, 2);
                                }
                            case EEdgeBlock.RightDown:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.DownRight:
                                {
                                    return new Coordinate(0, 2);
                                }
                            case EEdgeBlock.DownCenter:
                                {
                                    return new Coordinate(0, 1);
                                }
                            case EEdgeBlock.DownLeft:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.LeftDown:
                                {
                                    return new Coordinate(0, 0);
                                }
                            case EEdgeBlock.LeftCenter:
                                {
                                    return new Coordinate(1, 0);
                                }
                            case EEdgeBlock.LeftUp:
                                {
                                    return new Coordinate(2, 0);
                                }
                        }
                        #endregion
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            throw new RubikException("Błąd podczas pobierania współrzednych dla sąsiedniego bloku - GetNeighbourEdgeBlock");
        }

        /// <summary>
        /// zwraca numer sąsiedniej ścianki według podanego parametru
        /// </summary>
        /// <param name="neighbour"></param>
        /// <returns></returns>
        public int GetNeighbourSurfaceOrderNumber(ENeighbourSurface neighbour)
        {
            switch (this.orderNumber)
            {
                case 1:
                    {
                        switch (neighbour)
                        {
                            case ENeighbourSurface.Down:
                                {
                                    return 3;
                                }
                            case ENeighbourSurface.Up:
                                {
                                    return 6;
                                }
                            case ENeighbourSurface.Left:
                                {
                                    return 2;
                                }
                            case ENeighbourSurface.Right:
                                {
                                    return 4;
                                }
                            case ENeighbourSurface.Back:
                                {
                                    return 5;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        switch (neighbour)
                        {
                            case ENeighbourSurface.Down:
                                {
                                    return 5;
                                }
                            case ENeighbourSurface.Up:
                                {
                                    return 1;
                                }
                            case ENeighbourSurface.Left:
                                {
                                    return 6;
                                }
                            case ENeighbourSurface.Right:
                                {
                                    return 3;
                                }
                            case ENeighbourSurface.Back:
                                {
                                    return 4;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        switch (neighbour)
                        {
                            case ENeighbourSurface.Down:
                                {
                                    return 5;
                                }
                            case ENeighbourSurface.Up:
                                {
                                    return 1;
                                }
                            case ENeighbourSurface.Left:
                                {
                                    return 2;
                                }
                            case ENeighbourSurface.Right:
                                {
                                    return 4;
                                }
                            case ENeighbourSurface.Back:
                                {
                                    return 6;
                                }
                        }
                        break;
                    }
                case 4:
                    {
                        switch (neighbour)
                        {
                            case ENeighbourSurface.Down:
                                {
                                    return 5;
                                }
                            case ENeighbourSurface.Up:
                                {
                                    return 1;
                                }
                            case ENeighbourSurface.Left:
                                {
                                    return 3;
                                }
                            case ENeighbourSurface.Right:
                                {
                                    return 6;
                                }
                            case ENeighbourSurface.Back:
                                {
                                    return 2;
                                }
                        }
                        break;
                    }
                case 5:
                    {
                        switch (neighbour)
                        {
                            case ENeighbourSurface.Down:
                                {
                                    return 6;
                                }
                            case ENeighbourSurface.Up:
                                {
                                    return 3;
                                }
                            case ENeighbourSurface.Left:
                                {
                                    return 2;
                                }
                            case ENeighbourSurface.Right:
                                {
                                    return 4;
                                }
                            case ENeighbourSurface.Back:
                                {
                                    return 1;
                                }
                        }
                        break;
                    }
                case 6:
                    {
                        switch (neighbour)
                        {
                            case ENeighbourSurface.Down:
                                {
                                    return 1;
                                }
                            case ENeighbourSurface.Up:
                                {
                                    return 5;
                                }
                            case ENeighbourSurface.Left:
                                {
                                    return 2;
                                }
                            case ENeighbourSurface.Right:
                                {
                                    return 4;
                                }
                            case ENeighbourSurface.Back:
                                {
                                    return 3;
                                }
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            throw new RubikException("Błąd podczas pobierania numeru orderNumber dla sąsiedniej ścianki - GetNeighbourSurfaceOrderNumber");
        }

        /// <summary>
        /// narysuj ściankę kostki rubika na przekaznym kontekście graficznym
        /// </summary>
        /// <param name="g"></param>
        /// <param name="size">długość boku kwadrata</param>
        public void DrawFace(Graphics g, int size)
        {
            try
            {
                Rectangle r;
                int rectSize = size / 3;

                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        r = new Rectangle(j * rectSize, i * rectSize, rectSize, rectSize);
                        //using(SolidBrush brush=new SolidBrush(colors[i, j]))
                        //{
                        SolidBrush brush = new SolidBrush(colors[i, j]);        //kolor
                        g.FillRectangle(brush, r);
                        Pen pen = new Pen(Color.Black, 1);                      //czarne obramowanie
                        g.DrawRectangle(pen, r);
                        //}
                    }
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
        /// rysuje tylko jedną kratkę o podanych wymiarach
        /// </summary>
        /// <param name="g"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="size"></param>
        //public void DrawFace(Graphics g, int x, int y, int size)
        //{
        //    try
        //    {
        //        Rectangle r;
        //        int rectSize = size / 3;
                
        //        r = new Rectangle(y * rectSize, x * rectSize, rectSize, rectSize);
        //        SolidBrush brush = new SolidBrush(colors[x, y]);        //kolor
        //        g.FillRectangle(brush, r);
        //        Pen pen = new Pen(Color.Black, 1);                      //czarne obramowanie
        //        g.DrawRectangle(pen, r);
        //    }
        //    catch (RubikException ex)
        //    {

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        /// <summary>
        /// ustawia kolor na wybranej pozycji
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="color"></param>
        public void SetColor(int row, int col, Color color)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2)
                throw new RubikException("Nieprawidłowe wartości w SetColor. row:" + row + " col: " + col);

            colors[row, col] = Color.FromArgb(color.R, color.G, color.B);
        }

        /// <summary>
        /// zapisz całą tablicę do obiektu
        /// </summary>
        /// <param name="_colors"></param>
        public void SetColors(Color[,] _colors)
        {
            if (_colors.GetLength(0) != 3 || _colors.GetLength(1) != 3)
                throw new RubikException("Do funkcji Surface.SetColors przekazano tablicę kolorów o złych wymiarach (ma być 3x3)");

            this.colors = _colors;
        }

        /// <summary>
        /// zwraca kolor na konkretnej pozycji
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public Color GetColor(int row, int col)
        {

            if (row < 0 || row > 2 || col < 0 || col > 2)
                throw new RubikException("Nieprawidłowe wartości w GetColor. row:" + row + " col: " + col);

            return colors[row, col];
        }

        /// <summary>
        /// zwraca wszystkie kolory
        /// </summary>
        /// <returns></returns>
        public Color[,] GetColors()
        {
            return colors;
        }
    }

    /// <summary>
    /// klasa reprezentuje kostkę
    /// </summary>
    public class Cube
    {
        private Surface[] surfaces { get; set; }

        public Cube()
        {
            surfaces = new RubikResolverEngine.Surface[6];
        }

        /// <summary>
        /// ustawia płaszczyzny dla tej kostki
        /// </summary>
        /// <param name="surfaces"></param>
        public void SetSurfaces(Surface[] surfaces)
        {
            if (surfaces == null)
                throw new RubikException("Tablica surface nie może być null - SetSurface");
            if (surfaces.Length != 6)
                throw new RubikException("Tablice surface musi mieć 6 elementów - SetSurface");

            //todo: walidacja, że żaden z elementów nie jest null

            this.surfaces = surfaces;
        }

        /// <summary>
        /// zwraca całą listę płaższczyzn kostki
        /// </summary>
        /// <returns></returns>
        public Surface[] GetSurfaces()
        {
            if (surfaces == null)
                throw new RubikException("Tablica surface nie może być null - GetSurfaces");
            if (surfaces.Length != 6)
                throw new RubikException("Tablice surface musi mieć 6 elementów - GetSurfaces");

            return surfaces;
        }

        /// <summary>
        /// zwraca pojedynczą ściankę kostki
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <returns></returns>
        public Surface GetSurface(int orderNumber)
        {
            if (orderNumber < 1 || orderNumber > 6)
                throw new RubikException("Podano nieprawidłowy parametr w funkcji GetSurface (" + orderNumber + ")");
            if (surfaces == null)
                throw new RubikException("Tablica surface jest null ! - GetSurface");
            //if (surfaces[orderNumber] == null)
            //    throw new RubikException("Elemenet w tablicy surface na pozycji " + orderNumber + " jest null ! - GetSurface");

            return surfaces[orderNumber - 1];
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="move"></param>
        ///// <param name="clockwise"></param>
        ///// <returns></returns>
        //public Surface[] Move(EMove move, bool isClockwise)
        //{
        //    //chyba nie pójdę tą drogą
        //    return null;
        //}

        ///// <summary>
        ///// wykonuje ruch okrężny daną ścianką
        ///// </summary>
        ///// <param name="g">kontekst graficzny, gdzie ma być odrysowany ruch</param>
        ///// <param name="faceOrderNumter">numer ścianki</param>
        ///// <param name="isClockwise">czy ma być zgodnie z ruchem wskazówek zegara</param>
        ///// <returns></returns>
        //public Surface[] Move(Graphics g, int faceOrderNumber, bool isClockwise)
        //{
        //    //todo:
        //    try
        //    {
        //        //narysuj strzałkę jak kreścić ścianką
        //        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 8);
        //        pen.StartCap = LineCap.ArrowAnchor;
        //        pen.EndCap = LineCap.RoundAnchor;
        //        g.DrawLine(pen, 10, 10, 20, 50);

        //        //zaktualizuj dane o kostce
        //        var surface = GetSurface(faceOrderNumber);
        //        //todo: zrób coś ze surface i ją zaktulizuj
        //        return surfaces;

        //        ////using(SolidBrush brush=new SolidBrush(colors[i, j]))
        //        ////{
        //        //SolidBrush brush = new SolidBrush(colors[i, j]);        //kolor
        //        //        g.FillRectangle(brush, r);
        //        //        Pen pen = new Pen(Color.Black, 1);                      //czarne obramowanie
        //        //        g.DrawRectangle(pen, r);
        //        //        //}
        //    }
        //    catch (RubikException ex)
        //    {

        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //    return surfaces;
        //}

        /// <summary>
        /// robi ruch
        /// </summary>
        /// <param name="g"></param>
        /// <param name="move"></param>
        /// <returns></returns>
        public Surface[] Move(Graphics g, Move move, bool isReverse)
        {
            try
            {
                //narysuj strzałkę jak kreścić ścianką
                PaintMove(g, move, isReverse);

                //zaktualizuj dane o kostce
                var sCenter = GetSurface(move.faceNumber);
                //todo: zrób coś ze surface i ją zaktulizuj
                var sUp = GetSurface(sCenter.GetNeighbourSurfaceOrderNumber(ENeighbourSurface.Up));
                var sDown = GetSurface(sCenter.GetNeighbourSurfaceOrderNumber(ENeighbourSurface.Down));
                var sLeft = GetSurface(sCenter.GetNeighbourSurfaceOrderNumber(ENeighbourSurface.Left));
                var sRight = GetSurface(sCenter.GetNeighbourSurfaceOrderNumber(ENeighbourSurface.Right));

                //var tmpCenterColors = sCenter.GetColors();
                //var tmpUpColors = sUp.GetColors();
                //var tmpDownColors = sDown.GetColors();
                //var tmpRightColors = sRight.GetColors();
                //var tmpLeftColors = sLeft.GetColors();
                Color[,] tmpCenterColors = new Color[3, 3];
                Color[,] tmpUpColors = new Color[3, 3];
                Color[,] tmpDownColors = new Color[3, 3];
                Color[,] tmpRightColors = new Color[3, 3];
                Color[,] tmpLeftColors = new Color[3, 3];
                Array.Copy(sCenter.GetColors(), tmpCenterColors, 9);
                Array.Copy(sUp.GetColors(), tmpUpColors, 9);
                Array.Copy(sDown.GetColors(), tmpDownColors, 9);
                Array.Copy(sRight.GetColors(), tmpRightColors, 9);
                Array.Copy(sLeft.GetColors(), tmpLeftColors, 9);

                if ((!isReverse && move.clockwise) || (isReverse && !move.clockwise))
                //if (move.clockwise)
                {
                    #region
                    sCenter.SetColor(0, 0, tmpCenterColors[2, 0]);
                    sCenter.SetColor(0, 1, tmpCenterColors[1, 0]);
                    sCenter.SetColor(0, 2, tmpCenterColors[0, 0]);
                    sCenter.SetColor(1, 0, tmpCenterColors[2, 1]);
                    sCenter.SetColor(1, 2, tmpCenterColors[0, 1]);
                    sCenter.SetColor(2, 0, tmpCenterColors[2, 2]);
                    sCenter.SetColor(2, 1, tmpCenterColors[1, 2]);
                    sCenter.SetColor(2, 2, tmpCenterColors[0, 2]);
                    
                    sRight.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightUp).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightUp).y,
                        tmpUpColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpLeft).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpLeft).y]);
                    sRight.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter).y,
                        tmpUpColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter).y]);
                    sRight.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightDown).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightDown).y,
                         tmpUpColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpRight).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpRight).y]);

                    sDown.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownRight).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownRight).y,
                        tmpRightColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightUp).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightUp).y]);
                    sDown.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter).y,
                        tmpRightColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter).y]);
                    sDown.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownLeft).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownLeft).y,
                         tmpRightColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightDown).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightDown).y]);

                    sLeft.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftDown).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftDown).y,
                        tmpDownColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownRight).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownRight).y]);
                    sLeft.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter).y,
                        tmpDownColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter).y]);
                    sLeft.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftUp).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftUp).y,
                         tmpDownColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownLeft).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownLeft).y]);

                    sUp.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpLeft).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpLeft).y,
                        tmpLeftColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftDown).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftDown).y]);
                    sUp.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter).y,
                        tmpLeftColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter).y]);
                    sUp.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpRight).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpRight).y,
                         tmpLeftColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftUp).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftUp).y]);
                    #endregion
                }
                else
                {
                    #region
                    sCenter.SetColor(0, 0, tmpCenterColors[0, 2]);
                    sCenter.SetColor(0, 1, tmpCenterColors[1, 2]);
                    sCenter.SetColor(0, 2, tmpCenterColors[2, 2]);
                    sCenter.SetColor(1, 0, tmpCenterColors[0, 1]);
                    sCenter.SetColor(1, 2, tmpCenterColors[2, 1]);
                    sCenter.SetColor(2, 0, tmpCenterColors[0, 0]);
                    sCenter.SetColor(2, 1, tmpCenterColors[1, 0]);
                    sCenter.SetColor(2, 2, tmpCenterColors[2, 0]);

                    sRight.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightUp).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightUp).y,
                        tmpDownColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownRight).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownRight).y]);
                    sRight.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter).y,
                        tmpDownColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter).y]);
                    sRight.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightDown).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightDown).y,
                         tmpDownColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownLeft).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownLeft).y]);

                    sDown.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownRight).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownRight).y,
                        tmpLeftColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftDown).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftDown).y]);
                    sDown.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter).y,
                        tmpLeftColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter).y]);
                    sDown.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownLeft).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.DownLeft).y,
                         tmpLeftColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftUp).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftUp).y]);

                    sLeft.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftDown).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftDown).y,
                        tmpUpColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpLeft).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpLeft).y]);
                    sLeft.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter).y,
                        tmpUpColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter).y]);
                    sLeft.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftUp).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.LeftUp).y,
                         tmpUpColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpRight).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpRight).y]);

                    sUp.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpLeft).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpLeft).y,
                        tmpRightColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightUp).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightUp).y]);
                    sUp.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter).y,
                        tmpRightColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter).y]);
                    sUp.SetColor(sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpRight).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.UpRight).y,
                         tmpRightColors[sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightDown).x, sCenter.GetNeighbourEdgeBlock(EEdgeBlock.RightDown).y]);
                    #endregion
                }

                return surfaces;

                ////using(SolidBrush brush=new SolidBrush(colors[i, j]))
                ////{
                //SolidBrush brush = new SolidBrush(colors[i, j]);        //kolor
                //        g.FillRectangle(brush, r);
                //        Pen pen = new Pen(Color.Black, 1);                      //czarne obramowanie
                //        g.DrawRectangle(pen, r);
                //        //}
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            return surfaces;
        }

        /// <summary>
        /// odrysowuje ruch - i tylko to, nie zmienia danych
        /// </summary>
        /// <param name="g"></param>
        /// <param name="move"></param>
        public void PaintMove(Graphics g, Move move, bool isReverse)
        {
            try
            {
                if (move == null)
                    return;

                Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 6);

                if ((!isReverse && move.clockwise) || (isReverse && !move.clockwise))
                //if ((!move.reverse && move.clockwise) || (move.reverse && !move.clockwise))
                //if(move.clockwise)
                {
                    pen.StartCap = LineCap.RoundAnchor;
                    pen.EndCap = LineCap.ArrowAnchor;
                }
                else
                {
                    pen.StartCap = LineCap.ArrowAnchor;
                    pen.EndCap = LineCap.RoundAnchor;
                }

                Rectangle rectangle = new Rectangle(5, 5, 60, 60);

                //g.DrawLine(pen, 10, 10, 20, 50);
                //if (move.clockwise)
                    g.DrawArc(pen, rectangle, 270F, 315F);
                //else
                //    g.DrawArc(pen, rectangle, 45F, 315F);

            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// zwraca numer ściany, gdzie centrom jest podany jako argument kolor
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public int GetFaceNoForColor(Color color)
        {
            try
            {
                for (int i = 0; i < surfaces.Count(); i++)
                    if (surfaces[i].GetColor(1, 1) == color)
                        return i;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            throw new RubikException("Nie w kostce rubika koloru " + color.Name);
        }

        #region resolver

        /// <summary>
        /// sprwadza czy ścianka o podanym numerze jest ułożona
        /// </summary>
        /// <param name="faceNo"></param>
        /// <returns></returns>
        public bool IsSurfaceComplete(int faceNo)
        {
            try
            {
                var s = GetSurface(faceNo);
                var color = s.GetColor(0, 0);
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        if (s.GetColor(i, j) != color)
                            return false;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            return true;
        }

        /// <summary>
        /// sprawdza czy całość jest już ułożona
        /// </summary>
        /// <returns></returns>
        public bool IsAllComplete()
        {
            try
            {
                for (int i = 1; i <= surfaces.Count(); i++)
                    if (!IsSurfaceComplete(i))
                        return false;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            return true;
        }

        /// <summary>
        /// sprawdza czy jest ułożony poprawnie krzyż z kolorami na danej ścianie
        /// </summary>
        /// <param name="faceNo"></param>
        /// <returns></returns>
        public bool IsCrossComplete(int faceNo)
        {
            try
            {
                var s = GetSurface(faceNo);

                var centerColor = s.GetColor(1, 1);

                //góra
                if (s.GetColor(0, 1) != centerColor)
                    return false;
                Surface upNeighbour = GetSurface(s.GetNeighbourSurfaceOrderNumber(ENeighbourSurface.Up));
                Coordinate upCor = s.GetNeighbourEdgeBlock(EEdgeBlock.UpCenter);
                if (upNeighbour.GetColor(upCor.x, upCor.y) != upNeighbour.GetColor(1, 1))
                    return false;

                //right
                if (s.GetColor(1, 2) != centerColor)
                    return false;
                Surface rightNeighbour = GetSurface(s.GetNeighbourSurfaceOrderNumber(ENeighbourSurface.Right));
                Coordinate rightCor = s.GetNeighbourEdgeBlock(EEdgeBlock.RightCenter);
                if (rightNeighbour.GetColor(rightCor.x, rightCor.y) != rightNeighbour.GetColor(1, 1))
                    return false;

                //down
                if (s.GetColor(2, 1) != centerColor)
                    return false;
                Surface downNeighbour = GetSurface(s.GetNeighbourSurfaceOrderNumber(ENeighbourSurface.Down));
                Coordinate downCor = s.GetNeighbourEdgeBlock(EEdgeBlock.DownCenter);
                if (downNeighbour.GetColor(downCor.x, downCor.y) != downNeighbour.GetColor(1, 1))
                    return false;

                //left
                if (s.GetColor(1, 0) != centerColor)
                    return false;
                Surface leftNeighbour = GetSurface(s.GetNeighbourSurfaceOrderNumber(ENeighbourSurface.Left));
                Coordinate leftCor = s.GetNeighbourEdgeBlock(EEdgeBlock.LeftCenter);
                if (leftNeighbour.GetColor(leftCor.x, leftCor.y) != leftNeighbour.GetColor(1, 1))
                    return false;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            return true;
        }
        #endregion
    }

    /// <summary>
    /// klasa reprezentuje ruch jedną z sześciu płaszczyzn
    /// </summary>
    public class Move
    {
        public int faceNumber { get; private set; } //którą ścianę obracamy
        public bool clockwise { get; private set; } //kręcimy zgodnie czy odwrotnie do ruchu wskazówek zegara
        //public bool reverse { get; private set; }

        public Move()
        {

        }

        public Move(int faceNumber, bool clockwise)
        {
            this.faceNumber = faceNumber;
            this.clockwise = clockwise;
            //reverse = false;
        }

        ///// <summary>
        ///// ustaw czy ruch ma być wykonany normalnie czy odwrotnie
        ///// </summary>
        ///// <param name="reverse"></param>
        //public void SetReverse(bool reverse)
        //{
        //    this.reverse = reverse;
        //}
    }

    public struct Coordinate
    {
        public int x, y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    /// <summary>
    /// własna klasa na świadome wyjątki
    /// </summary>
    public class RubikException : Exception
    {
        public RubikException(string msg) : base(msg)
        {

        }
    }

    ///// <summary>
    ///// rodzaej ruchów - raczej nie będzie używane
    ///// </summary>
    //public enum EMove
    //{
    //    R,L,U,D,F,M,B
    //}

    /// <summary>
    /// określa sąsiedztwo dla danej ścianki
    /// </summary>
    public enum ENeighbourSurface
    {
        Up, Down, Left, Right, Back
    }

    /// <summary>
    /// określa sąsiedni klocek po krawędzi patrząc na wprost płaszczyzny
    /// </summary>
    public enum EEdgeBlock
    {
        UpLeft, UpCenter, UpRight, RightUp, RightCenter, RightDown, DownRight, DownCenter, DownLeft, LeftDown, LeftCenter, LeftUp
    }
}
