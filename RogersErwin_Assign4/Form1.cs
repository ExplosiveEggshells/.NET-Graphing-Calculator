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
            jarDriver = new JARDriver(ref graphParams, ref GraphPB, ref LogRichTextBox);

            jarDriver.LinearColor = Color.White;
            jarDriver.QuadraticColor = Color.Red;
            jarDriver.CubicColor = Color.Green;
            jarDriver.CircleColor = Color.Blue;
        }

        private void GraphPB_Paint(object sender, PaintEventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.PaintGraph(sender, e);
        }

        /*
         * Bounds integer x between -100 and 100 (inclusive). This is to be used on the
         * coefficient text fields.
         */
        private int BoundCoefficient(int x) {
            if (x > 100)
            {
                LogRichTextBox.AppendText("WARNING: " + x + " is too large! Coefficient has been set to 100.\n");
                return 100;
            }

            if (x < -100)
            {
                LogRichTextBox.AppendText("WARNING: " + x + " is too small! Coefficient has been set to -100.\n");
                return -100;
            }

            return x;
        }

        /*
         * Same as above, but bounds x to 0 and 100 instead. Made for bounding r in the circle
         * formula.
         */
        private int BoundR2(int x)
        {
            if (x > 100)
            {
                LogRichTextBox.AppendText("WARNING: " + x + " is too large! Coefficient has been set to 100.\n");
                return 100;
            }

            if (x < 1)
            {
                LogRichTextBox.AppendText("WARNING: " + x + " is too small! Coefficient has been set to -100.\n");
                return 1;
            }

            return x;
        }
        
#region EVENT_HANDLERS

        private void LinearColorButton_Click(object sender, EventArgs e)
        {
            if (LinearColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                jarDriver.LinearColor = LinearColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nLinear: {0}", LinearColorDialog.Color));

                GraphPB.Refresh();
            }
        }
        private void LinearButton_Click(object sender, EventArgs e)
        {
            if (MTextBox.TextLength != 0 && BTextBox.TextLength != 0)
            {
                int linearM = Convert.ToInt32(MTextBox.Text);
                int linearB = Convert.ToInt32(BTextBox.Text);
                LogRichTextBox.AppendText(string.Format("\ny = {0}x + {1}\n", linearM, linearB));

                jarDriver.SetLinear(linearM, linearB);
                GraphPB.Refresh();

            }
        }
        private void QuadColorButton_Click(object sender, EventArgs e)
        {
            if (QuadColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                jarDriver.QuadraticColor = QuadColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nQuadratic: {0}", QuadColorDialog.Color));

                GraphPB.Refresh();
            }
        }
        private void QuadButton_Click(object sender, EventArgs e)
        {
            if (AQuadTextBox.TextLength != 0 && BQuadTextBox.TextLength != 0 && CQuadTextBox.TextLength != 0)
            {
                int quadraticA = Convert.ToInt32(AQuadTextBox.Text);
                int quadraticB = Convert.ToInt32(BQuadTextBox.Text);
                int quadraticC = Convert.ToInt32(CQuadTextBox.Text);
                LogRichTextBox.AppendText(string.Format("\ny = {0}x\xB2 + {1}x + {2}\n", quadraticA, quadraticB, quadraticC));

                jarDriver.SetQuadratic(quadraticA, quadraticB, quadraticC);
                GraphPB.Refresh();
            }
        }

        private void CubicColorButton_Click(object sender, EventArgs e)
        {
            if (CubicColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                jarDriver.CubicColor = CubicColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nCubic: {0}", CubicColorDialog.Color));

                GraphPB.Refresh();
            }
        }
        private void CubicButton_Click(object sender, EventArgs e)
        {
            if (ACubicTextBox.TextLength != 0 && BCubicTextBox.TextLength != 0 && CCubicTextBox.TextLength != 0 && DCubicTextBox.TextLength != 0)
            {
                int cubicA = Convert.ToInt32(ACubicTextBox.Text);
                int cubicB = Convert.ToInt32(BCubicTextBox.Text);
                int cubicC = Convert.ToInt32(CCubicTextBox.Text);
                int cubicD = Convert.ToInt32(DCubicTextBox.Text);
                LogRichTextBox.AppendText(string.Format("\ny = {0}x\xB3 + {1}x\xB2 + {2}x + {3}\n", cubicA, cubicB, cubicC, cubicD));

                jarDriver.SetCubic(cubicA, cubicB, cubicC, cubicD);
                GraphPB.Refresh();
            }
        }
        private void CircleColorButton_Click(object sender, EventArgs e)
        {
            if (CircleColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                jarDriver.CircleColor = CircleColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nCircle: {0}", CircleColorDialog.Color));

                GraphPB.Refresh();
            }
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            if (HTextBox.TextLength != 0 && KTextBox.TextLength != 0 && R2TextBox.TextLength != 0)
            {
                int circleH = Convert.ToInt32(HTextBox.Text);
                int circleK = Convert.ToInt32(KTextBox.Text);
                int circleR = Convert.ToInt32(R2TextBox.Text);

                LogRichTextBox.AppendText(string.Format("\n(x - {0})\xB2 + (y - {1})\xB2 = {2}\xB2\n", circleH, circleK, circleR));

                jarDriver.SetCircle(circleH, circleK, circleR);
                GraphPB.Refresh();
            }
        }

        private void CoordinatesButton_Click(object sender, EventArgs e)
        {
            graphParams.XMin = Convert.ToInt32(XMinNumericUpDown.Value);
            graphParams.XMax = Convert.ToInt32(XMaxNumericUpDown.Value);
            graphParams.XInterval = Convert.ToInt32(XIntervalNumericUpDown.Value);

            graphParams.YMin = Convert.ToInt32(YMinNumericUpDown.Value);
            graphParams.YMax = Convert.ToInt32(YMaxNumericUpDown.Value);
            graphParams.YInterval = Convert.ToInt32(YIntervalNumericUpDown.Value);

            if (graphParams.XMin >= graphParams.XMax)
            {
                graphParams.XMin = graphParams.XMax - 1;
                XMinNumericUpDown.Value = graphParams.XMin;
            }

            if (graphParams.YMin >= graphParams.YMax)
            {
                graphParams.YMin = graphParams.YMax - 1;
                YMinNumericUpDown.Value = graphParams.YMin;
            }

            GraphPB.Refresh();
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
                MTextBox.Text = "0";
            }
            MTextBox.Text = BoundCoefficient(Convert.ToInt32(MTextBox.Text)).ToString();
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
                BTextBox.Text = "0";
            }

            BTextBox.Text = BoundCoefficient(Convert.ToInt32(BTextBox.Text)).ToString();
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
                AQuadTextBox.Text = "0";
            }

            AQuadTextBox.Text = BoundCoefficient(Convert.ToInt32(AQuadTextBox.Text)).ToString();
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
                BQuadTextBox.Text = "0";
            }

            BQuadTextBox.Text = BoundCoefficient(Convert.ToInt32(BQuadTextBox.Text)).ToString();
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
                CQuadTextBox.Text = "0";
            }

            CQuadTextBox.Text = BoundCoefficient(Convert.ToInt32(CQuadTextBox.Text)).ToString();
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
                ACubicTextBox.Text = "0";
            }

            ACubicTextBox.Text = BoundCoefficient(Convert.ToInt32(ACubicTextBox.Text)).ToString();
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
                BCubicTextBox.Text = "0";
            }

            BCubicTextBox.Text = BoundCoefficient(Convert.ToInt32(BCubicTextBox.Text)).ToString();
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
                CCubicTextBox.Text = "0";
            }

            CCubicTextBox.Text = BoundCoefficient(Convert.ToInt32(CCubicTextBox.Text)).ToString();
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
                DCubicTextBox.Text = "0";
            }

            DCubicTextBox.Text = BoundCoefficient(Convert.ToInt32(DCubicTextBox.Text)).ToString();
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
                HTextBox.Text = "0";
            }

            HTextBox.Text = BoundCoefficient(Convert.ToInt32(HTextBox.Text)).ToString();
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
                KTextBox.Text = "0";
            }

            KTextBox.Text = BoundCoefficient(Convert.ToInt32(KTextBox.Text)).ToString();
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
                R2TextBox.Text = "1";
            }

            R2TextBox.Text = BoundR2(Convert.ToInt32(R2TextBox.Text)).ToString();
        }
        private void LogRichTextBox_TextChanged(object sender, EventArgs e)
        {
            LogRichTextBox.SelectionStart = LogRichTextBox.Text.Length;
            LogRichTextBox.ScrollToCaret();
        }
    }
    #endregion
}
