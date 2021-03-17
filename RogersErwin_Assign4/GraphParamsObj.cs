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

        public GraphParamsObj(ref PictureBox graphBox, int xMin, int xMax, int xInterval, int yMin, int yMax, int yInterval)
        {
            this.graphBox = graphBox;
            this.xMin = xMin;
            this.xMax = xMax;
            this.xInterval = xInterval;
            this.yMin = yMin;
            this.yMax = yMax;
            this.yInterval = yInterval;
        }

        public int XMin { get { return xMin; } set { xMin = value; } }
        public int XMax { get { return xMax; } set { xMax = value; } }
        public int XInterval { get { return xInterval; } set { xInterval = value; } }

        public int YMin { get { return yMin; } set { yMin = value; } }
        public int YMax { get { return yMax; } set { yMax = value; } }
        public int YInterval { get { return yInterval; } set { yInterval = value; } }
    }
}
