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
         * 
         * In order to work with the window's dynamic sizing feature, the point
         * should be ran through ScalePointToBox and TranslatePointByScope
         * respectively
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

        /*
         * Translates a point to make it properly pan with the window's x and y offsets.
         * For instance, if the xMin is 0 and xMax is 200, then we should expect the point
         * (0,0) to actually be moved 100 units left.
         * 
         * 
         */
        public Point TranslatePointByScope(Point p)
        {
            int xMiddle = (int)((gParms.XMax + gParms.XMin) * 0.5);
            int yMiddle = (int)((gParms.YMax + gParms.YMin) * 0.5);

            p.X -= xMiddle;
            p.Y -= yMiddle;

            return p;
        }

        /*
         * Scales a Point's values to properly match the size of the window. For instance,
         * if the xMin is -10 and xMax is 10, we should expect a point at (9,9) to be nearly
         * right up against the top-right of the window's space.
         */
        public Point ScalePointToBox(Point p)
        {
            p.X = (int)(p.X * gParms.XScalar);
            p.Y = (int)(p.Y * gParms.YScalar);

            outputRtb.AppendText(p.ToString() + String.Format("\tXScalar: {0: 0.000} | YScalar: {1: 0.000}", gParms.XScalar, gParms.YScalar));
            outputRtb.AppendText("HI: " + graphPB.Width);

            return p;
        }

        public Point FullConvertCartesian(Point p)
        {
            p = ScalePointToBox(p);
            p = TranslatePointByScope(p);
            p = ConvertCartesianToPBPnt(p);

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

                Point p1 = new Point(-8, -8);
                Point p2 = new Point(8, 8);

                p1 = FullConvertCartesian(p1);
                p2 = FullConvertCartesian(p2);

                g.DrawLine(pen, p1, p2);
            }
        }

        private void PaintAxis(Graphics g, Pen pen)
        {
            pen.Color = Color.Goldenrod;

            
        }
    }
}
