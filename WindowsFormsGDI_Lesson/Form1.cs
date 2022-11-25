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
            this.Text = "FONT";

            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //объект Graphics использует методы для отображения
                                     //изображения на экране

            Font f = new Font("Verdana", 14, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Hello Font", f, Brushes.Blue, 30, 50);        
            g.DrawString("Hello Font", f, Brushes.Lime, 30, 70);        
            
            g.Dispose();
        }
    }
}
