/*
 * NAME:    GraphParamsObj.cs
 * AUTHORS: Jake Rogers (z1826513), Jon Erwin (z1856469)
 * 
 * This object more or less functions as a DTO, neatly packaging multiple
 * parameters regarding the graph into one object.
 * 
 * Furthermore, it also updates and stores dervied attributes about
 * the graph picture box 
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
    class GraphParamsObj
    {
        private PictureBox graphBox;

        private int xMin;
        private int xMax;
        private int xInterval;
        private int yMin;
        private int yMax;
        private int yInterval;

        private Point graphCenter;
        private double aspect;              // Aspect Ratio of the (y-axis range / x-axis range)
        private double xScalar;             // Multiplier for cartesian points to properly scale to the picture box window size.
        private double yScalar;

        public GraphParamsObj(ref PictureBox graphBox, int xMin, int xMax, int xInterval, int yMin, int yMax, int yInterval)
        {
            this.graphBox = graphBox;
            this.xMin = xMin;
            this.xMax = xMax;
            this.xInterval = xInterval;
            this.yMin = yMin;
            this.yMax = yMax;
            this.yInterval = yInterval;
            CalculateAspect();
            CalculateGraphCenter();
            RecalculateScalars();
        }

        public void CalculateAspect()
        {
            int xSize = xMax - xMin;
            int ySize = yMax - yMin;
            aspect = (double)ySize / (double)xSize;
        }

        public void CalculateGraphCenter()
        {
            graphCenter = new Point((int)(graphBox.Width * 0.5), (int)(graphBox.Height * 0.5));
        }

        public void RecalculateScalars()
        {
            xScalar = ((double)graphBox.Width / (double)(xMax - xMin));
            yScalar = ((double)graphBox.Height / (double)(yMax - yMin));
        }

        public int XMin { get { return xMin; } set { xMin = value; RecalculateScalars(); } }
        public int XMax { get { return xMax; } set { xMax = value; RecalculateScalars(); } }
        public int XInterval { get { return xInterval; } set { xInterval = value; } }

        public int YMin { get { return yMin; } set { yMin = value; RecalculateScalars(); } }
        public int YMax { get { return yMax; } set { yMax = value; RecalculateScalars(); } }
        public int YInterval { get { return yInterval; } set { yInterval = value; } }

        public Point GraphCenter { get { return graphCenter; } }
        public double Aspect { get { return aspect; } }
        public double XScalar { get { return xScalar; } }
        public double YScalar { get { return yScalar; } }
    }
}
