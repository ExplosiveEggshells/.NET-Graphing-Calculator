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
        private PictureBox graphPB;
        private RichTextBox outputRtb;

        public JARDriver(ref GraphParamsObj graphParams, ref PictureBox graphPB, ref RichTextBox outputRtb)
        {
            this.gParms = graphParams;
            this.graphPB = graphPB;
            this.outputRtb = outputRtb;
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

        public Point TranslatePointByScope(Point p)
        {
            int xMiddle = (int)((gParms.XMax + gParms.XMin) * 0.5);
            int yMiddle = (int)((gParms.YMax + gParms.YMin) * 0.5);

            p.X -= xMiddle;
            p.Y -= yMiddle;

            return p;
        }

        // -----===== PAINTING =====----- //

        public void PaintGraph(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen pen = new Pen(Color.White))
            {
                PaintAxis(g, pen);

                pen.Color = Color.White;
                Point p1 = ConvertCartesianToPBPnt(-100, -100);
                Point p2 = ConvertCartesianToPBPnt(100, 100);

                p1 = TranslatePointByScope(p1);
                p2 = TranslatePointByScope(p2);

                g.DrawLine(pen, p1, p2);
            }
        }

        private void PaintAxis(Graphics g, Pen pen)
        {
            pen.Color = Color.Goldenrod;
            // Y-Axis
            Point northPnt = new Point(gParms.GraphCenter.X, 0);
            Point southPnt = new Point(gParms.GraphCenter.X, graphPB.Height);

            g.DrawLine(pen, northPnt, southPnt);
        }
    }
}
