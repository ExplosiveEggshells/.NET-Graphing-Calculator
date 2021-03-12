using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogersErwin_Assign4
{
    class JARDriver
    {
        private GraphParamsObj gParms;

        public JARDriver(ref GraphParamsObj graphParams)
        {
            this.gParms = graphParams;
        }

        private void Initialize()
        {

        }

        /*
         * Taking in mathematical cartesian x,y point (+x => right, +y => up),
         * return a point that represents that point's equivalent spot in a
         * the graphBox.
         */
        public Point ConvertCartesianToPBPnt(Point p)
        {
            Point newPoint = new Point();
            newPoint.X = ((int)(p.X * gParms.Aspect) + gParms.GraphCenter.X);
            newPoint.Y = (-p.Y + gParms.GraphCenter.Y);

            return newPoint;
        }

        /*
         * Overload for above
         */
        public Point ConvertCartesianToPBPnt(int x, int y)
        {
            Point p = new Point(x, y);
            return ConvertCartesianToPBPnt(p);
        }

        public void PaintGraph(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen pen = new Pen(Color.White))
            {
                Point p1 = ConvertCartesianToPBPnt(-100, -100);
                Point p2 = ConvertCartesianToPBPnt(100, 100);

                g.DrawLine(pen, p1, p2);
            }
        }
    }
}
