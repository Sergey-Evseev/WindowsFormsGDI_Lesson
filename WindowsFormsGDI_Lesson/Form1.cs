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
            this.Text = "IMAGE";

            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //объект Graphics использует методы для отображения
                                     //изображения на экране
            Rectangle rect = this.ClientRectangle;//get rectangle that represents 
                                                  //client area of the control (в данном случае формы)
                                                              
            Image im = new Bitmap("Cat.bmp"); // Initializes a new instance
            // of the System.Drawing.Bitmap class from the specified file
            g.DrawImage (im, rect);
            g.Dispose();
        }
    }
}
