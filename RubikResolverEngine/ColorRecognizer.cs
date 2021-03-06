﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Collections;

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
        Color[,] matrix;
        int probeXsize;
        int probeYsize;

        //meta ustawienia 
        int _probeSize = 30;//30;//20;    //na ile kwadratów chcę podzielić krótszy bok obrazka
        Bitmap _bitmap;
        int _colorRecognizerOffsetSign = 60;    //margines błędu w przypadku składowej RGB znaczącej (np.: R dla Red)
        int _colorRecognizerOffsetNotSign = 90; //margines błędu dla składowych nieznaczących
        int _blackEdge = 0;                      //szerokosc krawedzi pomiedzy koorami

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
        public Surface Recognize(int orderNumber)// Bitmap _bitmap)
        {
            try
            {
                if (_bitmap == null)
                    throw new RubikException("Brak zainicjalizowanej bitmapy. Recognize");

                Surface surface = new Surface(orderNumber);

                int width = _bitmap.Width;
                int height = _bitmap.Height;
                int qSize = 0;                     //wielkość w pixelach kwadrata, na które będzie podzielony obrazek

                //oblicz parametry dzielenia obrazka na kwadraty
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
                matrix = new Color[probeYsize, probeXsize];

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

                //test
                File.WriteAllText("matrix2.txt", "");
                for (int i = 0; i < probeYsize; i++)
                {
                    for (int j = 0; j < probeXsize; j++)
                    {
                        File.AppendAllText("matrix2.txt", " (" + i + ", " + j + ") " + matrix[i, j].ToString() + "  ");
                    }

                    File.AppendAllText("matrix2.txt", Environment.NewLine);
                }

                //TODO: wykryć z matrixa siatkę 3x3 kostki rubika
                int squareSize = GetSquareSize();

                //oblicz kolory
                var colors = GetRecognizeColors(squareSize);
                surface.SetColors(colors);

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

                //WERSJA I
                /*
                //red
                if (clr.R > 180 && clr.G < 70 & clr.B < 70)
                    return Color.Red;

                //blue
                if (clr.R < 80 && clr.G < 200 && clr.B > 180)
                    return Color.Blue;

                //green
                if ((clr.G - clr.R > 100 && clr.G - clr.B > 100)
                    || (clr.G > 120 && clr.G - clr.R > 25 && clr.G - clr.B > 25))
                    return Color.Green;

                //white
                if (clr.R > 232 && clr.G > 232 && clr.B > 232)
                    return Color.White;

                //orange
                if (clr.R - clr.G > 100 && clr.G - clr.B > 100)
                    return Color.Orange;

                //yellowe
                if (clr.R > 200 && clr.G > 200 && clr.B < 150)
                    return Color.Yellow;
                */

                //WERSKA II
                /*
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
                    && Math.Abs(Color.Orange.G - clr.G) < 30//_colorRecognizerOffsetSign
                    && clr.B <= _colorRecognizerOffsetNotSign)
                    return Color.Orange;

                //yellow
                if (Color.Yellow.R - clr.R < _colorRecognizerOffsetSign
                    && Color.Yellow.G - clr.G < _colorRecognizerOffsetSign
                    && clr.B <= _colorRecognizerOffsetNotSign)
                    return Color.Yellow;
                */


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

                //WERSJA III
                int redDif, blueDif, greenDif, yellowDif, orangeDif, whiteDif, blackDif;

                redDif = Math.Abs(Color.Red.R - clr.R) + Math.Abs(Color.Red.G - clr.G) + Math.Abs(Color.Red.B - clr.B);
                blueDif = Math.Abs(Color.DarkBlue.R - clr.R) + Math.Abs(Color.DarkBlue.G - clr.G) + Math.Abs(Color.DarkBlue.B - clr.B);
                greenDif = Math.Abs(Color.Green.R - clr.R) + Math.Abs(Color.Green.G - clr.G) + Math.Abs(Color.Green.B - clr.B);
                yellowDif = Math.Abs(Color.Yellow.R - clr.R) + Math.Abs(Color.Yellow.G - clr.G) + Math.Abs(Color.Yellow.B - clr.B);
                orangeDif = Math.Abs(Color.DarkOrange.R - clr.R) + Math.Abs(Color.DarkOrange.G - clr.G) + Math.Abs(Color.DarkOrange.B - clr.B);
                whiteDif = Math.Abs(Color.White.R - clr.R) + Math.Abs(Color.White.G - clr.G) + Math.Abs(Color.White.B - clr.B);
                blackDif = Math.Abs(Color.Black.R - clr.R) + Math.Abs(Color.Black.G - clr.G) + Math.Abs(Color.Black.B - clr.B);

                Hashtable ht = new Hashtable();
                ht.Add("red", redDif);
                ht.Add("blue", blueDif);
                ht.Add("green", greenDif);
                ht.Add("yellow", yellowDif);
                ht.Add("orange", orangeDif);
                ht.Add("white", whiteDif);
                ht.Add("black", blackDif);

                var difList = ht.Cast<DictionaryEntry>().OrderBy(e => e.Value).ToList();
                var minDif = difList.FirstOrDefault();

                if (minDif.Key.ToString() == "red") return Color.Red;
                if (minDif.Key.ToString() == "blue") return Color.Blue;
                if (minDif.Key.ToString() == "green") return Color.Green;
                if (minDif.Key.ToString() == "yellow") return Color.Yellow;
                if (minDif.Key.ToString() == "orange") return Color.Orange;
                if (minDif.Key.ToString() == "white") return Color.White;
                else return Color.Black;

                //if (minDif.Key.ToString() == "red") return Color.Red;

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

        /// <summary>
        /// zwraca długosć boku kwadratu. jednostką obliczeniową jest mały kwadracik, na które podzielono obrazek
        /// </summary>
        /// <returns></returns>
        private int GetSquareSize()
        {
            try
            {
                if (matrix == null)
                    throw new RubikException("Nie zainicjowana zmienna matrix");
                if (matrix.Length == 0)
                    throw new RubikException("Zmienna matrix jest pusta!");

                int start = -1, end = -1;

                for (int i = probeYsize/2; i < probeYsize; i++)     //zacznij od połowy kostki
                {
                    for (int j = 0; j < probeXsize; j++)
                    {
                        if (matrix[i, j] != Color.Black)
                        {
                            if (start == -1)
                                start = j;
                            else
                                end = j;
                        }
                    }

                    if (start >= -1 && end > -1)
                        break;
                    else
                    {
                        start = -1;
                        end = -1;
                    }
                }

                return (end - start) / 3;
            }

            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            throw new RubikException("Nie udało się policzyć długości jednego kwadracika");
        }

        /// <summary>
        /// zlicz ile jest innych kolorów niż czarny w wierszu
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private int CountColorsOtherThenBlackInRow(int row)
        {
            try
            {
                int count = 0;
                for(int i = 0; i < probeXsize; i++)
                {
                    if (matrix[row, i] != Color.Black)
                        count++;
                }

                return count;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            return 0;
        }

        /// <summary>
        /// rozpoznaje już konkretne kolory na kostce
        /// </summary>
        /// <param name="qSize"></param>
        /// <returns></returns>
        private Color[,] GetRecognizeColors(int qSize)
        {
            //todo: źle działą - do poprawki. nie rozpoznaje dobrze kolorów (albo bierze złe próbki)

            try
            {
                Color[,] value = new Color[3, 3];
                int x = 0, y = 0;

                //znajdź lewy górny róg kostki
                bool firstRow = true;                   //zmienna pomocnicza, żeby ominąć pierwszy wiersz w celu korekty (zdjęcia nie są idealne)
                for (int i = 0; i < probeYsize; i++)     
                {
                    for (int j = 0; j < probeXsize; j++)
                    {
                        if (matrix[i, j] != Color.Black)
                            //&& CountColorsOtherThenBlackInRow(i) > qSize)   //dodatkowy warunek, żeby wykluczyć "nierówności" na zdjęciu (jak jakiś kolor wystaje pojedynczo poza kostkę)
                        {
                            if (firstRow)
                            {
                                firstRow = false;
                                i++;
                                break;
                            }
                            else
                            {
                                x = i;
                                y = j;
                                i = probeYsize + 1;  //żeby wyjść z tej pętli
                                break;
                            }
                        }
                    }
                }

                //połowa boku kwadracika - do obliczeń jaki kolor
                int halfSquare = qSize / 2;

                //test
                File.WriteAllText("namiary.txt", "");

                //sprawdzaj kolory w kwadracie 3x3
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        //pobiera kolor mniej więcej z środka małego kwadracika
                        //pobiera po prostu jedną próbkę i na podstawie jej wyznacza kolor kwadratu
                        //value[i, j] = matrix[x + halfSquare + i * qSize, y + halfSquare + j * qSize];
                        //sprawdź kolory na około i czego jest więcej to zapisz
                        int centerX = x + halfSquare + i * qSize + i * _blackEdge;
                        int centerY = y + halfSquare + j * qSize + j * _blackEdge;
                        Color[,] tmpClrTab = new Color[3, 3];
                        tmpClrTab[0, 0] = matrix[centerX - 1, centerY - 1];
                        tmpClrTab[0, 1] = matrix[centerX - 1, centerY];
                        tmpClrTab[0, 2] = matrix[centerX - 1, centerY + 1];
                        tmpClrTab[1, 0] = matrix[centerX, centerY - 1];
                        tmpClrTab[1, 1] = matrix[centerX, centerY];
                        tmpClrTab[1, 2] = matrix[centerX, centerY + 1];
                        tmpClrTab[2, 0] = matrix[centerX + 1, centerY - 1];
                        tmpClrTab[2, 1] = matrix[centerX + 1, centerY];
                        tmpClrTab[2, 2] = matrix[centerX + 1, centerY + 1];
                        value[i, j] = ApproximateColor(tmpClrTab);

                        //test
                        File.AppendAllText("namiary.txt", "i: " + i + "  j:  " + j + " (" + centerX + ", " + centerY + ")" + Environment.NewLine);
                    }
                }

                return value;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            throw new RubikException("Nie udało się rozpoznać kolorów.");
        }

        /// <summary>
        /// zwraca kolor, którego jest najwięcej w przekazanej tablicy
        /// </summary>
        /// <param name="aprxMatrix"></param>
        /// <returns></returns>
        private Color ApproximateColor(Color[,] aprxMatrix)
        {
            try
            {
                List<Color> colorList = new List<Color>();

                int dim0Length = aprxMatrix.GetLength(0);
                int dim1Length = aprxMatrix.GetLength(1);
                for (int i = 0; i < dim0Length ; i++)
                {
                    for (int j = 0; j < dim1Length; j++)
                    {
                        colorList.Add(aprxMatrix[i, j]);
                    }
                }

                var result = colorList.GroupBy(c => c).Select(g => new { color = g.Key, count = g.Count() }).OrderByDescending(x => x.count);
                return result.FirstOrDefault().color;
            }
            catch (RubikException ex)
            {

            }
            catch (Exception ex)
            {

            }

            return Color.Black;
        }

    }
}
