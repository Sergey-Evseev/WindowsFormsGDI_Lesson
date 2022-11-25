using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGDI_Lesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //объект Graphics использует методы для отображения
            //изображения на экране
            //принимает X, Y, width, height
            Rectangle rect = new Rectangle(20, 20, 200, 40);
            //градиентная кисть для смешивания двух цветов
            LinearGradientBrush lgBrush = new LinearGradientBrush(
                rect, Color.Red, Color.Green, 0.0f, true);
            //метод объекта Graphics принимает объекты Brush и Rectangle
            g.FillRectangle(lgBrush, rect);

            Rectangle rect2 = new Rectangle(20, 80, 200, 40);
            //HatchBrush заливает форму каким-либо узором
            HatchBrush hBrush = new HatchBrush(HatchStyle.DottedGrid, Color.AliceBlue);
            g.FillRectangle(hBrush, rect2);

            Rectangle rect3 = new Rectangle(20, 140, 200, 40);
            //TextureBrush заливает объекты растровым изображением
            TextureBrush tBrush = new TextureBrush(new Bitmap("grape.png"));
            g.FillRectangle(tBrush, rect3);

            g.Dispose();
        }
    }
}
