using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //применяем сглаживание
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //рисуем линию
            g.DrawLine(new Pen(Color.Violet, 3), 0, 0, 100, 100);
            //рисуем прямоугольник
            g.DrawRectangle(new Pen(Color.Goldenrod, 3), 0, 0, 100, 100);
            //рисуем пирог
            g.DrawPie(new Pen(Color.Indigo, 3), 150, 10, 150, 150, 90, 180);
            //рисуем текст
            g.DrawString("Hello GDI+", new Font("Consolas", 14, FontStyle.Bold), Brushes.Black, 10, 200);
            g.Dispose();
        }
    }
}
