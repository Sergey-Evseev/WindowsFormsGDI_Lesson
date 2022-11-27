using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //The System.Drawing.Graphics object used to paint. The System.Drawing.Graphics
                                     //     object provides methods for drawing objects on the display device.

            g.Clear(this.BackColor); //Clears the entire drawing surface and fills
                                             //it with the specified background color

            //создаем два прямоугольника
            Rectangle rect1 = new Rectangle(40, 100, 140, 140);
            Rectangle rect2 = new Rectangle(100, 100, 140, 140);

            // создаем два региона

            //Region Class describes the interior of a graphics shape composed of
            //rectangles and paths.
            //Region Constructor Initializes a new System.Drawing.Region
            //from the specified System.Drawing.Rectangle structure.
            Region rgn1 = new Region(rect1);
            Region rgn2 = new Region(rect2);

            g.DrawRectangle(Pens.Blue, rect1);//draws rectangle specified by Rectangle structure
            g.DrawRectangle(Pens.Red, rect2);

            //определяем область пересечения
            // Intersect Method: Updates this Region to the intersection of itself
            // with the specified System.Drawing.Region.
            rgn1.Intersect(rgn2);
            //rgn1.Intersect(rect2); //проверить если передать просто rectangle 

            //и заливаем ее зеленым цветом
            g.FillRegion(Brushes.Lime, rgn1);
            g.Dispose();
        }
    }
    
}
