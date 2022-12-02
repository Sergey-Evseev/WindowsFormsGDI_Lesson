using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRAPHICS_EXAMPLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            
        }
        //СПОСОБЫ ПОЛУЧЕНИЯ ОБЪЕКТА GRAPHICS

        //1) получение объекта Graphics из входного параметра PaintEventsArgs
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Font f = new Font("Yandex Sans Display", 45, FontStyle.Italic);
            g.DrawString("Hello SATAN", f, Brushes.DarkMagenta, 100, 100);
        }


        //2)переопределение виртуального метода OnPaint базового класса Control
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Graphics g = e.Graphics;
        //    Font f = new Font("Yandex Sans Display", 45, FontStyle.Italic);
        //    g.DrawString("Hello SATAN", f, Brushes.DarkMagenta, 100, 100);
        //}
                

    }
}
