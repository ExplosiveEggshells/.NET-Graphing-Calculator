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
        private JARDriver jarDriver;
        private GraphParamsObj graphParams;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            graphParams = new GraphParamsObj(ref GraphPB, -10, 10, 1, -10, 10, 1);
            jarDriver = new JARDriver(ref graphParams, ref GraphPB, ref richTextBox1);
        }

        private void GraphPB_Paint(object sender, PaintEventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.PaintGraph(sender, e);
        }

        private void XMinTrack_Scroll(object sender, EventArgs e)
        {
            if (xMinTrack.Value >= graphParams.XMax)
            {
                xMinTrack.Value = graphParams.XMax - 1;
            }
            graphParams.XMin = xMinTrack.Value;
            xMinText.Text = xMinTrack.Value.ToString();
            GraphPB.Refresh();
        }

        private void XMaxTrack_Scroll(object sender, EventArgs e)
        {
            if (xMaxTrack.Value <= graphParams.XMin)
            {
                xMaxTrack.Value = graphParams.XMin + 1;
            }
            graphParams.XMax = xMaxTrack.Value;
            xMaxText.Text = xMaxTrack.Value.ToString();
            GraphPB.Refresh();
        }

        private void XIntTrack_Scroll(object sender, EventArgs e)
        {
            graphParams.XInterval = xIntTrack.Value;
            xIntText.Text = xIntTrack.Value.ToString();
            GraphPB.Refresh();
        }

        private void YMinTrack_Scroll(object sender, EventArgs e)
        {
            if (yMinTrack.Value >= graphParams.YMax)
            {
                yMinTrack.Value = graphParams.YMax - 1;
            }
            graphParams.YMin = yMinTrack.Value;
            yMinText.Text = yMinTrack.Value.ToString();
            GraphPB.Refresh();
        }

        private void YMaxTrack_Scroll(object sender, EventArgs e)
        {
            if (yMaxTrack.Value <= graphParams.YMin)
            {
                yMaxTrack.Value = graphParams.YMin + 1;
            }
            graphParams.YMax = yMaxTrack.Value;
            yMaxText.Text = yMaxTrack.Value.ToString();
            GraphPB.Refresh();
        }

        private void YIntTrack_Scroll(object sender, EventArgs e)
        {
            graphParams.YInterval = YIntTrack.Value;
            yIntText.Text = YIntTrack.Value.ToString();
            GraphPB.Refresh();
        }

        private void SampleTrack_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            jarDriver.SampleSize = trackBar.Value;
            samplingText.Text = trackBar.Value.ToString();
            GraphPB.Refresh();
        }
    }
}
