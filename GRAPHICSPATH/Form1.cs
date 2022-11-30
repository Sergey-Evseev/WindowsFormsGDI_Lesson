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

namespace GRAPHICSPATH
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
            Graphics g = e.Graphics;

            //создаем массив точек
            Point[] points = {
                new Point (600, 10),
                new Point (100, 150),
                new Point (100, 240),
                new Point (500, 400),
            };
            
            GraphicsPath path1= new GraphicsPath ();
            path1.AddPolygon(points); //рисуем траекторию в виде многоугольника с вершинами массива  
            g.FillPath(Brushes.DarkOrchid, path1); //заполняем траекторию

            //рисуем вторую траеторию
            GraphicsPath path2 = new GraphicsPath();
            path2.StartFigure();
            path2.AddArc(500, 100, 400, 300, 600, 265);
            g.FillPath(Brushes.Lime, path2);
            path2.CloseFigure(); //соединяем концы фигуры
            g.DrawPath(new Pen(Color.CornflowerBlue, 4), path2); //обводим фигуру
            
            g.Dispose();

        }
    }
}
