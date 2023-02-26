//3 задача, 8 вариант, Бесшапошников Владимир
//Создать приложение, выполняющее построение правильного многоугольника с заданным числом сторон.
//Предусмотреть возможность управления размером и положением многоугольника с помощью мыши.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3task_kg
{
    public partial class Form1 : Form
    {
        Point p1;
        private int SidesNumber = 3;
        private int FigureSize = 200;
        public Form1()
        {
            InitializeComponent();
        }
        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {  
            SidesNumber = (int)numericUpDown1.Value;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            FigureSize = (int)numericUpDown2.Value * 50;
        }
        private void CreateFigure(int X1, int Y1) { 
            Graphics g = CreateGraphics();
            Point[] pts = new Point[SidesNumber];
            double theta = 3 * Math.PI / 2;
            double dtheta = (2 * Math.PI) / SidesNumber;
            for (int i = 0; i < pts.Length; i++)
            {
                pts[i].X = (int)(X1 + FigureSize * Math.Cos(theta));
                pts[i].Y = (int)(Y1 + FigureSize * Math.Sin(theta));
                theta += dtheta;
            }
            g.Clear(DefaultBackColor);
            g.DrawPolygon(Pens.Red, pts);
            g.FillPolygon(Brushes.DarkRed, pts);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            p1 = e.Location;
            CreateFigure(p1.X, p1.Y);
        }
    }
}
