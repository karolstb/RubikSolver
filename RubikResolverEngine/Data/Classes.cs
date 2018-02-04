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

                Color tmpColor;
                //Surface tmpSurface;
                //Color[,] tmpCenterColors = new Color[3, 3];

                if ((!isReverse && move.clockwise) || (isReverse && !move.clockwise))
                //if (move.clockwise)
                {
                    var tmpCenterColors = sCenter.GetColors();
                    var tmpUpColors = sUp.GetColors();
                    var tmpDownColors = sDown.GetColors();
                    var tmpRightColors = sRight.GetColors();
                    var tmpLeftColors = sLeft.GetColors();

                    sCenter.SetColor(0, 0, tmpCenterColors[2, 0]);
                    sCenter.SetColor(0, 1, tmpCenterColors[1, 0]);
                    sCenter.SetColor(0, 2, tmpCenterColors[0, 0]);
                    sCenter.SetColor(1, 0, tmpCenterColors[2, 1]);
                    sCenter.SetColor(1, 2, tmpCenterColors[0, 1]);
                    sCenter.SetColor(2, 0, tmpCenterColors[2, 2]);
                    sCenter.SetColor(2, 1, tmpCenterColors[1, 2]);

                    //todo: i tu jest problem bo nie mam info jaką krawedzią sąsiadują
                    
                }
                else
                {

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

    /// <summary>
    /// własna klasa na świadome wyjątki
    /// </summary>
    public class RubikException : Exception
    {
        public RubikException(string msg) : base(msg)
        {

        }
    }

    /// <summary>
    /// rodzaej ruchów - raczej nie będzie używane
    /// </summary>
    public enum EMove
    {
        R,L,U,D,F,M,B
    }

    /// <summary>
    /// określa sąsiedztwo dla danej ścianki
    /// </summary>
    public enum ENeighbourSurface
    {
        Up, Down, Left, Right
    }
}
