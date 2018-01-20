﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RubikResolverEngine
{
    public class Surface
    {
        //public Color MyProperty { get; set; }
        private Color[,] colors { get; set; }

        public Surface()
        {
            colors = new Color[3, 3];
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
                        r = new Rectangle(i * rectSize, j * rectSize, rectSize, rectSize);
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
    /// własna klasa na świadome wyjątki
    /// </summary>
    public class RubikException : Exception
    {
        public RubikException(string msg) : base(msg)
        {

        }
    }
}