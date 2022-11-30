using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COORDINATES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;                
        }

        //private PaintEventHandler Form1_Paint()
        //{
        //    throw new NotImplementedException();
        //}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //рисуем тестовую линию до смещения координат
            g.DrawLine(new Pen(Brushes.DarkOrange, 10), 0, 0, 400, 350);
            g.DrawLine(new Pen(Brushes.DarkGreen, 5), 300, 0, 450, 350);

            //сдвигаем начало координат страницы
            g.TranslateTransform(100, 50);

            //рисуем тестовую линию после смещения 
            g.DrawLine(new Pen(Brushes.DarkSeaGreen, 10), 0, 0, 400, 350);
            g.DrawLine(new Pen(Brushes.DarkRed, 5), 300, 0, 450, 350);
        }
    }
}
