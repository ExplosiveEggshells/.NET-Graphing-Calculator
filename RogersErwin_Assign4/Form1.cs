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

        private int linearM;
        private int linearB;
        private Color linearColor = Color.White;

        private int quadraticA;
        private int quadraticB;
        private int quadraticC;
        private Color quadraticColor = Color.Red;

        private int cubicA;
        private int cubicB;
        private int cubicC;
        private int cubicD;
        private Color cubicColor = Color.Green;

        private int circleK;
        private int circleH;
        private int circleR;
        private Color circleColor = Color.Blue;


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
        
#region EVENT_HANDLERS

        private void LinearColorButton_Click(object sender, EventArgs e)
        {
            if (LinearColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                linearColor = LinearColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nLinear: {0}", linearColor));
            }
       
        }
        private void LinearButton_Click(object sender, EventArgs e)
        {
            if (MTextBox.TextLength != 0 && BTextBox.TextLength != 0)
            {
                linearM = Convert.ToInt32(MTextBox.Text);
                linearB = Convert.ToInt32(BTextBox.Text);
                LogRichTextBox.AppendText(string.Format("\ny = {0}x + {1}", linearM, linearB));
            }
        }
        private void QuadColorButton_Click(object sender, EventArgs e)
        {
            if (QuadColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                quadraticColor = QuadColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nQuadratic: {0}", quadraticColor));

            }
        }
        private void QuadButton_Click(object sender, EventArgs e)
        {
            if (AQuadTextBox.TextLength != 0 && BQuadTextBox.TextLength != 0 && CQuadTextBox.TextLength != 0)
            {
                quadraticA = Convert.ToInt32(AQuadTextBox.Text);
                quadraticB = Convert.ToInt32(BQuadTextBox.Text);
                quadraticC = Convert.ToInt32(CQuadTextBox.Text);
                LogRichTextBox.AppendText(string.Format("\ny = {0}x\xB2 + {1}x + {2}", quadraticA, quadraticB, quadraticC));
            }
        }

        private void CubicColorButton_Click(object sender, EventArgs e)
        {
            if (CubicColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                cubicColor = CubicColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nCubic: {0}", cubicColor));

            }
        }
        private void CubicButton_Click(object sender, EventArgs e)
        {
            if (ACubicTextBox.TextLength != 0 && BCubicTextBox.TextLength != 0 && CCubicTextBox.TextLength != 0 && DCubicTextBox.TextLength != 0)
            {
                cubicA = Convert.ToInt32(ACubicTextBox.Text);
                cubicB = Convert.ToInt32(BCubicTextBox.Text);
                cubicC = Convert.ToInt32(CCubicTextBox.Text);
                cubicD = Convert.ToInt32(DCubicTextBox.Text);
                LogRichTextBox.AppendText(string.Format("\ny = {0}x\xB3 + {1}x\xB2 + {2}x + {3}", cubicA, cubicB, cubicC, cubicD));
            }
        }
        private void CircleColorButton_Click(object sender, EventArgs e)
        {
            if (CircleColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                circleColor = CircleColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nCircle: {0}", circleColor));
            }
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            if (HTextBox.TextLength != 0 && KTextBox.TextLength != 0 && R2TextBox.TextLength != 0)
            {
                circleH = Convert.ToInt32(HTextBox.Text);
                circleK = Convert.ToInt32(KTextBox.Text);
                circleR = Convert.ToInt32(R2TextBox.Text);

                LogRichTextBox.AppendText(string.Format("\n(x - {0})\xB2 + (y - {1})\xB2 = {2}\xB2", circleH, circleK, circleR));
            }
        }

        private void CoordinatesButton_Click(object sender, EventArgs e)
        {
            xMin = Convert.ToInt32(XMinNumericUpDown.Value);
            xMax = Convert.ToInt32(XMaxNumericUpDown.Value);
            xInterval = Convert.ToInt32(XIntervalNumericUpDown.Value);

            yMin = Convert.ToInt32(YMinNumericUpDown.Value);
            yMax = Convert.ToInt32(YMinNumericUpDown.Value);
            yInterval = Convert.ToInt32(YIntervalNumericUpDown.Value);

            LogRichTextBox.AppendText(
                string.Format("\nxMin: {0}\nxMax: {1}\nxInt: {2}\nyMin: {3}\nyMax: {4}\nyInt: {5}",
                    xMin, xMax, xInterval, yMin, yMax, yInterval)
                );

        }
        private void MTextBox_Enter(object sender, EventArgs e)
        {
            MTextBox.Clear();
            MTextBox.ForeColor = Color.White;
        }
        private void MTextBox_Leave(object sender, EventArgs e)
        {
            if (MTextBox.TextLength == 0)
            {
                MTextBox.ForeColor = Color.FromArgb(255,100,80,100);
                MTextBox.Text = "10";
            }
        }

        private void BTextBox_Enter(object sender, EventArgs e)
        {
            BTextBox.Clear();
            BTextBox.ForeColor = Color.White;
        }
        private void BTextBox_Leave(object sender, EventArgs e)
        {
            if (BTextBox.TextLength == 0)
            {
                BTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                BTextBox.Text = "10";
            }
        }

        private void AQuadTextBox_Enter(object sender, EventArgs e)
        {
            AQuadTextBox.Clear();
            AQuadTextBox.ForeColor = Color.White;
        }
        private void AQuadTextBox_Leave(object sender, EventArgs e)
        {
            if (AQuadTextBox.TextLength == 0)
            {
                AQuadTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                AQuadTextBox.Text = "10";
            }
        }

        private void BQuadTextBox_Enter(object sender, EventArgs e)
        {
            BQuadTextBox.Clear();
            BQuadTextBox.ForeColor = Color.White;
        }
        private void BQuadTextBox_Leave(object sender, EventArgs e)
        {
            if (BQuadTextBox.TextLength == 0)
            {
                BQuadTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                BQuadTextBox.Text = "10";
            }
        }

        private void CQuadTextBox_Enter(object sender, EventArgs e)
        {
            CQuadTextBox.Clear();
            CQuadTextBox.ForeColor = Color.White;
        }
        private void CQuadTextBox_Leave(object sender, EventArgs e)
        {
            if (CQuadTextBox.TextLength == 0)
            {
                CQuadTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                CQuadTextBox.Text = "10";
            }
        }
        private void ACubicTextBox_Enter(object sender, EventArgs e)
        {
            ACubicTextBox.Clear();
            ACubicTextBox.ForeColor = Color.White;
        }
        private void ACubicTextBox_Leave(object sender, EventArgs e)
        {
            if (ACubicTextBox.TextLength == 0)
            {
                ACubicTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                ACubicTextBox.Text = "10";
            }
        }
        private void BCubicTextBox_Enter(object sender, EventArgs e)
        {
            BCubicTextBox.Clear();
            BCubicTextBox.ForeColor = Color.White;
        }
        private void BCubicTextBox_Leave(object sender, EventArgs e)
        {
            if (BCubicTextBox.TextLength == 0)
            {
                BCubicTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                BCubicTextBox.Text = "10";
            }
        }
        private void CCubicTextBox_Enter(object sender, EventArgs e)
        {
            CCubicTextBox.Clear();
            CCubicTextBox.ForeColor = Color.White;
        }
        private void CCubicTextBox_Leave(object sender, EventArgs e)
        {
            if (CCubicTextBox.TextLength == 0)
            {
                CCubicTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                CCubicTextBox.Text = "10";
            }
        }
        private void DCubicTextBox_Enter(object sender, EventArgs e)
        {
            DCubicTextBox.Clear();
            DCubicTextBox.ForeColor = Color.White;
        }
        private void DCubicTextBox_Leave(object sender, EventArgs e)
        {
            if (DCubicTextBox.TextLength == 0)
            {
                DCubicTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                DCubicTextBox.Text = "10";
            }
        }
        private void HTextBox_Enter(object sender, EventArgs e)
        {
            HTextBox.Clear();
            HTextBox.ForeColor = Color.White;
        }
        private void HTextBox_Leave(object sender, EventArgs e)
        {
            if (HTextBox.TextLength == 0)
            {
                HTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                HTextBox.Text = "10";
            }
        }
        private void KTextBox_Enter(object sender, EventArgs e)
        {
            KTextBox.Clear();
            KTextBox.ForeColor = Color.White;
        }
        private void KTextBox_Leave(object sender, EventArgs e)
        {
            if (KTextBox.TextLength == 0)
            {
                KTextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                KTextBox.Text = "10";
            }
        }
        private void R2TextBox_Enter(object sender, EventArgs e)
        {
            R2TextBox.Clear();
            R2TextBox.ForeColor = Color.White;
        }
        private void R2TextBox_Leave(object sender, EventArgs e)
        {
            if (R2TextBox.TextLength == 0)
            {
                R2TextBox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                R2TextBox.Text = "10";
            }
        }
        private void LogRichTextBox_TextChanged(object sender, EventArgs e)
        {
            LogRichTextBox.SelectionStart = LogRichTextBox.Text.Length;
            LogRichTextBox.ScrollToCaret();
        }
    }
    #endregion
}
