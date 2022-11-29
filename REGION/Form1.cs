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

namespace REGION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //The System.Drawing.Graphics object used to paint. The System.Drawing.Graphics
                                     //     object provides methods for drawing objects on the display device.

            g.Clear(this.BackColor); //Clears the entire drawing surface and fills
                                             //it with the specified background color

            //создаем два прямоугольника
            Rectangle rect1 = new Rectangle(40, 40, 250, 250);
            Rectangle rect2 = new Rectangle(100, 100, 300, 200);

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


            Rectangle rect3 = new Rectangle(475, 225, 250, 150);            
            g.DrawRectangle(Pens.Brown, 450, 200, 300, 200);
            g.DrawEllipse(Pens.Green, rect3);
            Region reg3 = new Region(rect3);
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(325, 112, 315, 537, 44, 500, 25, 400);
            g.FillPath(Brushes.Yellow, path);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(475, 225, 250, 150);
            reg3.Xor(path2);
            g.FillRegion(Brushes.Violet, reg3);



            g.Dispose();
        }
    }
    
}
