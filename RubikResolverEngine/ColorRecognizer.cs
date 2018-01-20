using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

//red    255 0   0
//blue   0   0   255
//green  0   255 0
//white  0   0   0
//orange 255 165 0
//yellow 255 255 0

namespace RubikResolverEngine
{
    public class ColorRecognizer
    {
        //meta ustawienia 
        int _probeSize = 10;    //na ile kwadratów chcę podzielić krótszy bok obrazka
        Bitmap _bitmap;
        int _colorRecognizerOffsetSign = 60;    //margines błędu w przypadku składowej RGB znaczącej (np.: R dla Red)
        int _colorRecognizerOffsetNotSign = 90; //margines błędu dla składowych nieznaczących

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="bitmap"></param>
        public ColorRecognizer(Bitmap bitmap)
        {
            _bitmap = bitmap;
        }

        /// <summary>
        /// na podstawie przekazanej bitmapy zwraca dane, gdzie jest jaki kolor na kostce rubika
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public Surface Recognize()// Bitmap _bitmap)
        {
            try
            {
                if (_bitmap == null)
                    throw new RubikException("Brak zainicjalizowanej bitmapy. Recognize");

                Surface surface = new Surface();

                int width = _bitmap.Width;
                int height = _bitmap.Height;
                int qSize = 0;                     //wielkość w pixelach kwadrata, na które będzie podzielony obrazek

                //oblicz parametry dzielenia obrazka na kwadraty
                int probeXsize;
                int probeYsize;
                if (width < height)
                {
                    qSize = width / _probeSize;
                    probeXsize = _probeSize;
                    probeYsize = height / qSize;
                }
                else
                {
                    qSize = height / _probeSize;
                    probeYsize = _probeSize;
                    probeXsize = width / qSize;
                }

                //wymiary próbek (kwadratów) na jakich będzie badany kolor
                //int pWidth = width / _probeXsize;        
                //int pHeight = height / _probeYsize;

                //tymczasowa siatka bitmapy z kolorami
                Color[,] matrix = new Color[probeYsize, probeXsize];

                for (int i = 0; i < probeYsize; i++)
                {
                    for(int j = 0; j < probeXsize; j++)
                    {
                        //Bitmap partBitmap = GetPartOfBitmap(j * pWidth, i * pHeight, pWidth, pHeight);  //pobierz kawałek obrazka
                        Bitmap partBitmap = GetPartOfBitmap(j * qSize, i * qSize, qSize, qSize);  //pobierz kawałek obrazka
                        matrix[i, j] = GetAvgColor(partBitmap);                                         //oblicz uśredniony kolor
                        matrix[i, j] = ProcessForRubikColors(matrix[i, j]);                             //sprawdź czy jest tam jakiś kolor z kostki rubika
                    }
                }

                //TODO: wykryć z matrixa siatkę 3x3 kostki rubika

                #region byle co
                //https://stackoverflow.com/questions/1068373/how-to-calculate-the-average-rgb-color-values-of-a-bitmap
                //BitmapData srcData = bitmap.LockBits(
                //    new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                //    ImageLockMode.ReadOnly, bitmap.PixelFormat);//
                //PixelFormat.Format32bppArgb);
                // unsafe
                //{
                //byte* p = (byte*)(void*)Scan0;

                //for (int y = 0; y < height; y++)
                //{
                //    for (int x = 0; x < width; x++)
                //    {
                //        for (int color = 0; color < 3; color++)
                //        {
                //            int idx = (y * stride) + x * 4 + color;

                //            totals[color] += p[idx];
                //        }
                //    }
                //}
                // }
                #endregion

                return surface;
            }
            catch(RubikException ex)
            {

            }
            catch(Exception ex)
            {

            }

            return null;
        }

        /// <summary>
        /// funkcja, która na podstawie przekazanego koloru zwraca albo jakiś kolor z palety barw w kostce ruika
        /// albo czarny, który pełni tu rolę tła
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        private Color ProcessForRubikColors(Color clr)
        {
            //red    255 0   0
            //blue   0   0   255
            //green  0   128 0
            //white  255 255 255
            //orange 255 165 0
            //yellow 255 255 0

            //TODO: coś tu nie działa - do poprwaki ten algorytm. trzeba bardziej selektywnie sprawdzac konkretne kolory a nie w pętli

            try
            {
                //List<Color> rubikColors = new List<Color>();
                //rubikColors.Add(Color.Red);
                //rubikColors.Add(Color.Blue);
                //rubikColors.Add(Color.Green);
                //rubikColors.Add(Color.White);
                //rubikColors.Add(Color.Orange);
                //rubikColors.Add(Color.Yellow);
                //Color red = Color.Red;

                //red
                if (Color.Red.R - clr.R < _colorRecognizerOffsetSign
                    && clr.G <= _colorRecognizerOffsetNotSign && clr.B <= _colorRecognizerOffsetNotSign)
                    return Color.Red;

                //blue
                if (Color.Blue.B - clr.B < _colorRecognizerOffsetSign
                    && clr.R <= _colorRecognizerOffsetNotSign && clr.G <= _colorRecognizerOffsetNotSign)
                    return Color.Blue;

                //green
                if (Math.Abs(Color.Green.G - clr.G) < _colorRecognizerOffsetSign
                    && clr.R <= _colorRecognizerOffsetNotSign && clr.B <= _colorRecognizerOffsetNotSign)
                    return Color.Green;

                //white
                if (Color.White.R - clr.R < _colorRecognizerOffsetSign
                    && Color.White.G - clr.G < _colorRecognizerOffsetSign
                    && Color.White.B - clr.B < _colorRecognizerOffsetSign)
                    return Color.White;

                //orange
                if (Color.Orange.R - clr.R < _colorRecognizerOffsetSign
                    && Math.Abs(Color.Orange.G - clr.G) < _colorRecognizerOffsetSign
                    && clr.B <= _colorRecognizerOffsetNotSign)
                    return Color.Orange;

                //yellow
                if (Color.Yellow.R - clr.R < _colorRecognizerOffsetSign
                    && Color.Yellow.G - clr.G < _colorRecognizerOffsetSign
                    && clr.B <= _colorRecognizerOffsetNotSign)
                    return Color.Yellow;

                //foreach (Color color in rubikColors)
                //{
                    //inna metoda (nie działa)
                    //if (Math.Abs(clr.R - color.R) < _colorRecognizerOffset 
                    //    && Math.Abs(clr.G - color.G) < _colorRecognizerOffset 
                    //    && Math.Abs(clr.B - color.B)<_colorRecognizerOffset)
                    //{
                    //    return color;
                    //}
                //}

                //jak nie dopasowało do żadnego koloru to zwróć czarny
                return Color.Black;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            return Color.Black;
        }

        /// <summary>
        /// zwraca średni kolor na przekazanej bitmapie
        /// </summary>
        /// <param name="bmp"></param>
        /// <returns></returns>
        private Color GetAvgColor(Bitmap bmp)
        {
            try
            {
                Bitmap tmpBmp = new Bitmap(1, 1);
                //Bitmap orig = (Bitmap)Bitmap.FromFile("path");
                using (Graphics g = Graphics.FromImage(tmpBmp))
                {
                    // updated: the Interpolation mode needs to be set to 
                    // HighQualityBilinear or HighQualityBicubic or this method
                    // doesn't work at all.  With either setting, the results are
                    // slightly different from the averaging method.
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(bmp, new Rectangle(0, 0, 1, 1));
                }
                Color pixel = tmpBmp.GetPixel(0, 0);
                // pixel will contain average values for entire orig Bitmap
                //byte avgR = pixel.R; // etc.
                return Color.FromArgb(pixel.R, pixel.G, pixel.B);
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            throw new RubikException("Nie udało się obliczyć średniego koloru w funkcji GetAvgColor");
        }

        /// <summary>
        /// zwraca kawałek bitmapy 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private Bitmap GetPartOfBitmap(int x, int y, int width, int height)
        {
            try
            {
                if (_bitmap == null)
                    throw new RubikException("Brak zainicjalizowanej bitmapy. Recognize");

                // Clone a portion of the Bitmap object.
                Rectangle cloneRect = new Rectangle(x, y, width, height);
                System.Drawing.Imaging.PixelFormat format =
                    _bitmap.PixelFormat;
                Bitmap cloneBitmap = _bitmap.Clone(cloneRect, format);
                return cloneBitmap;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}
