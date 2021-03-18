/*
 * NAME: JARDriver.cs
 * AUTHOR: Jake Rogers (z1826513)
 * 
 * This file contains all of the logic for drawing equations on the PictureBox.
 * This was all separated out for the purpose of preventing merge conflicts.
 * 
 * In order to get points to paint on the window, a 'sampling' method was used.
 * This essentially means that a variable number of x-positions are picked between
 * the xMinimum and the xMaximum, and those values of paired with their corresponding
 * y value for that equation.
 * 
 * Then, those paired values are put into points and returned as an array to either be
 * used in a DrawLine or DrawCurve.
 * 
 * A slight exception is that SampleCircle samples a fixed number of points at equal
 * angles along the arc of the arithemetic circle, rather than picking x-values.
 */
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

        private int linearM;
        private int linearB;
        private Color linearColor = Color.White;
        private bool linearPlotted = false;

        private int quadraticA;
        private int quadraticB;
        private int quadraticC;
        private Color quadraticColor = Color.Red;
        private bool quadraticPlotted = false;

        private int cubicA;
        private int cubicB;
        private int cubicC;
        private int cubicD;
        private Color cubicColor = Color.Green;
        private bool cubicPlotted = false;

        private int circleK;
        private int circleH;
        private int circleR;
        private Color circleColor = Color.Blue;
        private bool circlePlotted = false;

        private int samplingSize = 100;
        private int SAMPLE_ANGLES_DELTA = 5;            // Step-size to use when sampling points for the circle equation.

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
        private Point CartesianToUIPoint(Point p)
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

        /*
         * Same as above, but works with float Points. (Used with circle sampling for bonus precision)
         */
        private Point CartesianToUIPoint(PointF p)
        {
            Point newP = new Point();
            newP.X = (int)((p.X - (float)gParms.XMin) / ((float)gParms.XMax - (float)gParms.XMin) * (float)graphPB.Width);
            newP.Y = (int)(((float)gParms.YMax - p.Y) / (((float)gParms.YMax - (float)gParms.YMin)) * (float)graphPB.Height);

            return newP;
        }

        // -----===== SAMPLING =====----- //

        /*
         * Returns a list of x-positions that should be sampled between xMin and xMax. 
         */
        private List<int> GetSamplePositions()
        {
            int adjustedSampleSize = Math.Min(samplingSize, gParms.XMax - gParms.XMin);         // If the sampling size is greater than the width of the viewing window, new sample size is that width.
            adjustedSampleSize = Math.Max(adjustedSampleSize, 2);                               // At the very least, have two samples.

            int sampleInterval = (gParms.XMax - gParms.XMin) / adjustedSampleSize;
            sampleInterval = Math.Max(sampleInterval, 1);

            List<int> xSamples = new List<int>();
            for (int i = 0; i < adjustedSampleSize; i++)
            {
                int xPos = (i * sampleInterval) + gParms.XMin;
                xSamples.Add(xPos);
            }

            xSamples.Insert(0, gParms.XMin);                                                          // Adjust the first xPos to be exactly the xMin
            xSamples.Add(gParms.XMax);

            return xSamples;
        }

        /*
         * Returns two points which are a linear sampling of y at xMin and xMax.
         * 
         * status will be true if the linear equation falls within scope, false
         * if not.
         */
        private Point[] SampleLinear(int m, int b, out bool status)
        {
            Point[] samples = new Point[2];

            int y1 = (m * gParms.XMin) + b;
            int y2 = (m * gParms.XMax) + b;

            samples[0] = CartesianToUIPoint(new Point(gParms.XMin, y1));
            samples[1] = CartesianToUIPoint(new Point(gParms.XMax, y2));

            if (y1 >= gParms.YMax && y2 >= gParms.YMax)
            {
                status = false;
            }
            else if (y1 <= gParms.YMin && y2 <= gParms.YMin)
            {
                status = false;
            }
            else
            {
                status = true;
            }

            return samples;
        }

        /*
         * Returns a variable number of points which are a quadratic sampling of
         * y at various positions between xMin and xMax
         */
        private Point[] SampleQuadratic(List<int> samplePositions, int a, int b, int c)
        {
            List<Point> DrawPoints = new List<Point>();
            foreach (int xPos in samplePositions)
            {
                int y = (a * (xPos * xPos)) + (b * xPos) + c;
                DrawPoints.Add(CartesianToUIPoint(new Point(xPos, y)));
            }

            return DrawPoints.ToArray<Point>();
        }

        /*
         * Same as above, but for Cubics.
         */
        private Point[] SampleCubic(List<int> samplePositions, int a, int b, int c, int d)
        {
            List<Point> DrawPoints = new List<Point>();
            foreach (int xPos in samplePositions)
            {
                int y = (a * (xPos * xPos * xPos) + (b * xPos * xPos) + (c * xPos) + d);
                DrawPoints.Add(CartesianToUIPoint(new Point(xPos, y)));
            }

            return DrawPoints.ToArray<Point>();
        }

        /*
         * Returns (360 / SAMPLE_ANGLE_DELTA) number of points which are a circular sampling
         * of y at every 5 degrees of rotation around the circle's edge.
         * 
         * Note: Circles are sampled using trigonometry to find the points, and drawn as a
         * curve of points instead of using the DrawEllipse function. This is done so that
         * it is easier to determine whether or not the circle is exactly within scope
         * or not.
         */
        private Point[] SampleCircle(int h, int k, int r)
        {
            float delta = (float)(((double)SAMPLE_ANGLES_DELTA * Math.PI) / 180);
            float pipi = (float)(Math.PI * 2.0);
            List<Point> samples = new List<Point>();
            for (float i = 0; i < pipi; i += delta)
            {
                PointF pnt = new PointF(((float)Math.Cos((double)i) * r) + circleH, ((float)Math.Sin((double)i) * r) + circleK);
                samples.Add(CartesianToUIPoint(pnt));
            }

            return samples.ToArray();
        }

        /*
         * Given an array of UI points, this function returns true if this function
         * would appear anywhere on the drawing field, and false if not.
         */
        private bool CheckScopeOnCurve(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].Y > 0 && points[i].Y < graphPB.Height)
                {
                    // If any point is between the min and max y, points is in scope.
                    return true;
                }

                if (i != 0)
                {
                    if (points[i - 1].Y < 0 && points[i].Y > 0)
                    {
                        // If the previous point is ever above YMax and but the current point is at all below YMax, points is in scope.
                        return true;
                    }

                    if (points[i - 1].Y > graphPB.Height && points[i].Y < graphPB.Height)
                    {
                        // If the previous point is ever below YMin, but the current point is at all above YMin, points is in scope.
                        return true;
                    }
                }
            }

            return false;
        }

        // -----===== PAINTING =====----- //

        /*
         * Directed to immediately by PaintPB_Graph in Form1.cs; this is called
         * each time GraphPB is refreshed. Calls various functions to get
         * Points of the four equations and draws them if they are valid.
         */
        public void PaintGraph(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen pen = new Pen(Color.White))
            {
                PaintAxis(g, pen);
                PaintTicks(g, pen);

                // Get X-Positions positions to sample.
                List<int> samplePositions = GetSamplePositions();

                pen.Width = 1.5f;

                if (linearPlotted)  // If the plot linear button was hit at least once...
                {
                    bool linearStatus;
                    Point[] line = SampleLinear(linearM, linearB, out linearStatus);    // Get sampled Points.
                    if (linearStatus)                                                   // If it falls in scope..
                    {
                        pen.Color = linearColor;
                        g.DrawLine(pen, line[0], line[1]);                              // Draw the line.
                    }
                    else                                                                // Otherwise, print scope warning.
                    {
                        outputRtb.Text = String.Format("Linear Equation y={0}x+{1} falls outside of window scope!", linearM, linearB);
                    }
                }

                if (quadraticPlotted)
                {
                    Point[] quad = SampleQuadratic(samplePositions, quadraticA, quadraticB, quadraticC);
                    if (CheckScopeOnCurve(quad))
                    {
                        pen.Color = quadraticColor;
                        g.DrawCurve(pen, quad);
                    }
                    else
                    {
                        outputRtb.AppendText(String.Format("Quadratic Equation y={0}x^2+{1}x+{2} falls outside of window scope!", quadraticA, quadraticB, quadraticC));
                    }
                }

                if (cubicPlotted)
                {
                    Point[] cubic = SampleCubic(samplePositions, cubicA, cubicB, cubicC, cubicD);
                    if (CheckScopeOnCurve(cubic))
                    {
                        pen.Color = cubicColor;
                        g.DrawCurve(pen, cubic);
                    }
                    else
                    {
                        outputRtb.AppendText(String.Format("Cubic Equation y={0}x^3+{1}x^2+{2}x+{3} falls outside of window scope!", cubicA, cubicB, cubicC, cubicD));
                    }
                }


                if (circlePlotted)
                {
                    Point[] circle = SampleCircle(circleH, circleK, circleR);
                    if (CheckScopeOnCurve(circle))
                    {
                        pen.Color = circleColor;
                        g.DrawCurve(pen, circle);
                    }
                    else
                    {
                        outputRtb.AppendText(String.Format("Circle Equation (x+{0})^2+(y+{1})^2={2}^2 falls outside of window scope!", circleH, circleK, circleR));
                    }
                }
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

        /*
         * Paints in the tick marks on both the x and y axes.
         */
        private void PaintTicks(Graphics g, Pen pen)
        {
            pen.Color = Color.MediumVioletRed;

            int firstTickX = ((gParms.XMin) / gParms.XInterval) * gParms.XInterval;
            double xScalar = (double)graphPB.Height * 0.10;                            // Scalar for the size of the ticks. Height * 0.10 means tick length will always be 10% of the pictureBox's height, regardless of scope.
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
                if (i == 0) { continue; }
                Point center = CartesianToUIPoint(new Point(yTickHorizontal, i));

                if (i == gParms.YMin) { center.Y--; }

                Point rightP = new Point(center.X + (int)(yScalar), center.Y);
                Point leftP = new Point(center.X - (int)(yScalar), center.Y);

                g.DrawLine(pen, leftP, rightP);
            }
        }

        /*
         * This, and the following 'Set' methods are used to
         * update their respective equations with values found in the 
         * user-input fields.
         */
        public void SetLinear(int linearM, int linearB)
        {
            this.linearM = linearM;
            this.linearB = linearB;
            linearPlotted = true;
        }

        public void SetQuadratic(int quadA, int quadB, int quadC)
        {
            quadraticA = quadA;
            quadraticB = quadB;
            quadraticC = quadC;
            quadraticPlotted = true;
        }

        public void SetCubic(int cubicA, int cubicB, int cubicC, int cubicD)
        {
            this.cubicA = cubicA;
            this.cubicB = cubicB;
            this.cubicC = cubicC;
            this.cubicD = cubicD;
            cubicPlotted = true;
        }

        public void SetCircle(int circleH, int circleK, int circleR)
        {
            this.circleH = circleH;
            this.circleK = circleK;
            this.circleR = circleR;
            circlePlotted = true;
        }

        
        // -----===== PROPERTIES =====-----

        public int SampleSize { get { return samplingSize; } set { samplingSize = value; } }
        public Color LinearColor { set { linearColor = value; } }
        public Color QuadraticColor { set { quadraticColor = value; } }
        public Color CubicColor { set { cubicColor = value; } }
        public Color CircleColor { set { circleColor = value; } }

    }
}
