using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRAPHICS_EXAMPLE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonSave.Click += buttonSave_Click;
                                    
            this.Paint += Form1_Paint2;
            this.Paint += Form1_Paint;
        }

        //получение объекта Graphics с помощью объекта Image 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try //блок try catch на слуай отсутствия файла
            {
                Bitmap myBitmap = new Bitmap("rose.bmp");
                //получаем объект Graphics ГОТОВЫЙ ИЗ ФАЙЛА
                Graphics gFromImage = Graphics.FromImage(myBitmap);
                //создаем объект font 
                Font f = new Font("Times New Roman", 40, FontStyle.Bold | FontStyle.Italic);
                //создаем надпись
                string helloStr = "Kate My Love";

                //измеряем строку методом MeasureString
                SizeF sz = gFromImage.MeasureString(helloStr, f);

                //на объекте пишем строку в координатах 10 10
                gFromImage.DrawString(helloStr, f, Brushes.Aqua, 10, 10);

                //на объекте рисуем прямоугольник размером с текст в координатах 10 10
                                       //(Pen pen), float X, float Y, float width, float height                                       
                gFromImage.DrawRectangle(new Pen(Color.Red, 3), 10.0F, 10.0F, sz.Width, sz.Height);
                //сохраняем новое изображение на диск
                myBitmap.Save(@"NewRose.bmp");
                Rectangle regionRec = new Rectangle(new Point(0, 0), myBitmap.Size);
                myBitmap.Dispose();
                gFromImage.Dispose();
                //метод принудительной перерисовки клиентской области
                //в габаритах и локацией рисунка
                this.Invalidate(regionRec);
            }
            catch { }
        }

        //обработчик события Paint
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Bitmap myBitmap = new Bitmap("NewRose.bmp");
                Graphics g = e.Graphics;
                g.DrawImage(myBitmap, 0, 0, 600, 400);
                myBitmap.Dispose();
                g.Dispose();
            }
            catch { }
        }

        //просто моя отрисовка по заданным параметрам
        private void Form1_Paint2(object sender, PaintEventArgs e)
        {
            Bitmap myBitmap = new Bitmap("rose.bmp");
            //получаем объект Graphics 
            Graphics g = e.Graphics;
            //создаем объект font 
            Font f = new Font("Times New Roman", 40, FontStyle.Bold | FontStyle.Italic);
            //создаем надпись
            string helloStr = "Kate My Love";

            g.DrawImage(myBitmap, 0, 0, 600, 400);
            g.DrawString(helloStr, f, Brushes.DarkOrchid, 100, 10);
        }
    }
}
