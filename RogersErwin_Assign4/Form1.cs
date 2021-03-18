/*
 * NAME: Form1.cs
 * AUTHORS: Jake Rogers (z1826513) 
 *          John Erwin (z1856469)
 * 
 * This file contains the functions that build the form (Form1) and
 * all the event handlers that are necessary to interact with the
 * form.  
 */
using System;
using System.Drawing;
using System.Linq;
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

        /**
         * Handles the change of the color for the Linear function
         */
        private void LinearColorButton_Click(object sender, EventArgs e)
        {
            if (LinearColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                jarDriver.LinearColor = LinearColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nLinear: {0}", LinearColorDialog.Color));

                GraphPB.Refresh();
            }
        }

        /**
         * Handles the updating of the linear function being drawn
         */
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

        /**
         * Handles the change of the color for the quadratic function
         */
        private void QuadColorButton_Click(object sender, EventArgs e)
        {
            if (QuadColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                jarDriver.QuadraticColor = QuadColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nQuadratic: {0}", QuadColorDialog.Color));

                GraphPB.Refresh();
            }
        }

        /**
         * Handles the updating of the quadratic function being drawn
         */
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

        /**
         * Handles the change of the color for the cubic function
         */
        private void CubicColorButton_Click(object sender, EventArgs e)
        {
            if (CubicColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                jarDriver.CubicColor = CubicColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nCubic: {0}", CubicColorDialog.Color));

                GraphPB.Refresh();
            }
        }

        /**
         * Handles the updating of the cubic function being drawn
         */
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

        /**
         * Handles the change of the color for the circle function
         */
        private void CircleColorButton_Click(object sender, EventArgs e)
        {
            if (CircleColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                jarDriver.CircleColor = CircleColorDialog.Color;
                LogRichTextBox.AppendText(string.Format("\nCircle: {0}", CircleColorDialog.Color));

                GraphPB.Refresh();
            }
        }

        /**
         * Handles the updating of the circle function being drawn
         */
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

        /**
         * Handles updating the coordinates that change what is visible on the PictureBox
         */
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
        /**
         * Handles removing the format shadowing and setting the color to active text (White)
         */
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            textbox.Clear();
            textbox.ForeColor = Color.White;
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.TextLength == 0)
            {
                textbox.ForeColor = Color.FromArgb(255,100,80,100);
                textbox.Text = "0";
            }
            textbox.Text = BoundCoefficient(Convert.ToInt32(textbox.Text)).ToString();
        }

        private void RTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.TextLength == 0)
            {
                textbox.ForeColor = Color.FromArgb(255, 100, 80, 100);
                textbox.Text = "1";
            }
            textbox.Text = BoundR2(Convert.ToInt32(textbox.Text)).ToString();
        }

        /**
         * This function makes sure that when a new item is added to the Log, it scrolls down as items are added.
         */
        private void LogRichTextBox_TextChanged(object sender, EventArgs e)
        {
            LogRichTextBox.SelectionStart = LogRichTextBox.Text.Length;
            LogRichTextBox.ScrollToCaret();
        }

        /**
         * This function makes sure that only numbers can be entered in the textbox forms
         * 
         * And it also ensures that a minus sign be placed once and at the begining of the TextBox
         */
        private void CleanUserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (textbox.Text.Contains('-') || textbox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }
    }
#endregion
}
