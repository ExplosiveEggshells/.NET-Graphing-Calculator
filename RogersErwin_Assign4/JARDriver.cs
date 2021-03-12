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
         * Takes the X and Y values in Point P and converts them to their respective points on the graphing
         * picture box, returning the result of that conversion as a new Point.
         * 
         * It also is sure to account for the drawing field's scope: If the field is shifted
         * x units to the right, all points will be shifted x points to the LEFT and then converted to 
         * pictureBox units.
         * 
         * It is entirely possible for a Point returned by this function to have a negative value for x or y,
         * meaning that it would be off screen. This is both okay and expected.
         */
        public Point CartesianToUIPoint(Point p)
        {
            /*
             * The following two calculations essentially do the same thing, but for X and Y. Here's what happens
             * with X:
             * 
             * 1) Figure out how close X is to xMax from xMin. Call this 'p'. (p = 0.8 if x = 18, xMin = 10, & xMax = 20)
             * 2) Multiply the width of the PictureBox by p to convert it to a PictureBox point.
             * 
             * With this method, cartesian points will be properly remapped to PictureBox points. This also inherently
             * accounts for potential x-axis skewing due to the PictureBox's aspect ratio.
             */
            p.X = (int)(((double)(p.X - gParms.XMin) / (double)(gParms.XMax - gParms.XMin)) * (double)graphPB.Width);
            p.Y = (int)(((double)(gParms.YMax - p.Y) / (double)(gParms.YMax - gParms.YMin)) * (double)graphPB.Height);

            return p;
        }


        // -----===== PAINTING =====----- //

        public void PaintGraph(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen pen = new Pen(Color.White))
            {
                PaintAxis(g, pen);
                PaintTicks(g, pen);
                pen.Color = Color.White;

                Point p1 = CartesianToUIPoint(new Point(-10, -10));
                Point p2 = CartesianToUIPoint(new Point(10, 10));


                g.DrawLine(pen, p1, p2);
            }
        }

        /*
         * Paints in the x and y axes.
         */
        private void PaintAxis(Graphics g, Pen pen)
        {
            pen.Color = Color.Goldenrod;

            Point northPoint = CartesianToUIPoint(new Point(0, gParms.YMax));           // Northern Point of the Y-Axis' y value will always just be the YMax; there is no reason for it to be any greater.
            Point southPoint = CartesianToUIPoint(new Point(0, gParms.YMin));           // Similar to above, but south is bounded to YMin.

            Point westPoint = CartesianToUIPoint(new Point(gParms.XMin, 0));            // Similar to above, but west is bounded to XMin.
            Point eastPoint = CartesianToUIPoint(new Point(gParms.XMax, 0));            // You get the picture ;)

            if (northPoint.X == graphPB.Width) { northPoint.X--; southPoint.X--; }      // If the Y-Axis is right up against the right-border, push it left one pixel so it actually displays in this (literal) edge case.
            if (westPoint.Y == graphPB.Height) { westPoint.Y--; eastPoint.Y--; }        // Ditto, but for the X-Axis. Push it up once if it is against the bottom-border

            // Draw the points.
            g.DrawLine(pen, southPoint, northPoint);
            g.DrawLine(pen, westPoint, eastPoint);
        }

        private void PaintTicks(Graphics g, Pen pen)
        {
            pen.Color = Color.MediumVioletRed;

            int firstTickX = ((gParms.XMin) / gParms.XInterval) * gParms.XInterval;
            double xScalar = (double) graphPB.Height * 0.10;                            // Scalar for the size of the ticks. Height * 0.10 means tick length will always be 10% of the pictureBox's height, regardless of scope.
            int xTickHeight = 0;                                                        // Height on the PictureBox where the line of x-tick marks should appear

            if (gParms.YMin > 0) { xTickHeight = gParms.YMin; }                         // If the YMin has moved above the x-axis, bring the tick marks up with it.
            else if (gParms.YMax < 0) { xTickHeight = gParms.YMax; }                    // Same, but bring them down if YMax has moved down below the y-axis.

            for (int i = firstTickX; i <= gParms.XMax; i += gParms.XInterval)           // Start i at the position of the first x-tick from the left. Increment it by XInterval every loop and continue as long as i is less than the max...
            {
                if (i == 0) { continue; }                                                   // If this tick would fall on the origin... Skip it.
                Point center = CartesianToUIPoint(new Point(i, xTickHeight));               // Create a new Point at x=i, with a y value following the rule given by xTickHeight.
                        
                if (i == gParms.XMax) { center.X--; }                                       // If this point would fall on the right-most edge... Push it back so that it actually appears.

                Point upP = new Point(center.X, center.Y + (int)(xScalar));             // Create a new point above the newly made point, xScalar units up
                Point downP = new Point(center.X, center.Y - (int)(xScalar));           // Same, but for below.

                g.DrawLine(pen, upP, downP);                                            // Draw in the new tick mark.
            }

            // Pretty much, repeat everything above but slightly modified for y-ticks.

            int firstTickY = ((gParms.YMin) / gParms.YInterval) * gParms.YInterval;
            double yScalar = xScalar;
            int yTickHorizontal = 0;

            if (gParms.XMin > 0) { yTickHorizontal = gParms.XMin; }
            else if (gParms.XMax < 0) { yTickHorizontal = gParms.XMax; }

            for (int i = firstTickY; i <= gParms.YMax; i += gParms.YInterval)
            {
                if (i == 0) { continue ;}
                Point center = CartesianToUIPoint(new Point(yTickHorizontal, i));

                if (i == gParms.YMin) { center.Y--; }
                
                Point rightP = new Point(center.X + (int)(yScalar), center.Y);
                Point leftP = new Point(center.X - (int)(yScalar), center.Y);

                g.DrawLine(pen, leftP, rightP);
            }
        }

    }
}
