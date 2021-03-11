using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersErwin_Assign4
{
    public partial class Form1 : Form
    {
        private int xMin = -100;
        private int xMax = 100;
        private int xInterval = 10;
        private int yMin = -100;
        private int yMax = 100;
        private int yInterval = 10;

        private double aspect = 1.0;

        private Point graphCenter;
        private PictureBox graphBox;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            graphBox = GraphPB;

            graphCenter = new Point(
                (int)(graphBox.Width * 0.5),
                (int)(graphBox.Height * 0.5)
            );

            int xSize = xMax - xMin;
            int ySize = yMax - yMin;
            aspect = (double)ySize / (double)xSize;
        }

        /*
         * Taking in mathematical cartesian x,y point (+x => right, +y => up),
         * return a point that represents that point's equivalent spot in a
         * the graphBox.
         */
        private Point ConvertCartesianToPBPnt(Point p)
        {
            Point newPoint = new Point();
            newPoint.X = ((int)(p.X * aspect) + graphCenter.X);
            newPoint.Y = (-p.Y + graphCenter.Y);

            return newPoint;
        }

        /*
         * Overload for above
         */
        private Point ConvertCartesianToPBPnt(int x, int y)
        {
            Point p = new Point(x, y);
            return ConvertCartesianToPBPnt(p);
        }

        private void PaintGraph(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen pen = new Pen(Color.White))
            {
                Point p1 = ConvertCartesianToPBPnt(-100, -100);
                Point p2 = ConvertCartesianToPBPnt(100, 100);


                g.DrawLine(pen, p1, p2);
            }
        }

        private void GraphPB_Paint(object sender, PaintEventArgs e)
        {
            PaintGraph(sender, e);
        }
    }
}
