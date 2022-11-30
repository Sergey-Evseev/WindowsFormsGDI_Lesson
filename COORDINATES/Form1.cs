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

            //сдвигаем начало координат страницы
            g.TranslateTransform(40, 50);

            //рисуем тестовую линию
            g.DrawLine(new Pen(Brushes.DarkSeaGreen, 10), 0, 0, 400, 350);
            g.DrawLine(new Pen(Brushes.DarkRed, 5), 200, 0, 400, 350);
        }
    }
}
