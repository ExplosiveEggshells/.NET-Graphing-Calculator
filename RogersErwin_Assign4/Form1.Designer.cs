namespace RogersErwin_Assign4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GraphPB = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.xMinTrack = new System.Windows.Forms.TrackBar();
            this.xMinText = new System.Windows.Forms.TextBox();
            this.xMaxTrack = new System.Windows.Forms.TrackBar();
            this.xMaxText = new System.Windows.Forms.TextBox();
            this.xIntTrack = new System.Windows.Forms.TrackBar();
            this.xIntText = new System.Windows.Forms.TextBox();
            this.yMinTrack = new System.Windows.Forms.TrackBar();
            this.yMaxTrack = new System.Windows.Forms.TrackBar();
            this.YIntTrack = new System.Windows.Forms.TrackBar();
            this.yMinText = new System.Windows.Forms.TextBox();
            this.yMaxText = new System.Windows.Forms.TextBox();
            this.yIntText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xIntTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YIntTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphPB
            // 
            this.GraphPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GraphPB.Location = new System.Drawing.Point(12, 12);
            this.GraphPB.Name = "GraphPB";
            this.GraphPB.Size = new System.Drawing.Size(692, 346);
            this.GraphPB.TabIndex = 0;
            this.GraphPB.TabStop = false;
            this.GraphPB.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPB_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 653);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(693, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // xMinTrack
            // 
            this.xMinTrack.Location = new System.Drawing.Point(0, 394);
            this.xMinTrack.Maximum = 100;
            this.xMinTrack.Minimum = -100;
            this.xMinTrack.Name = "xMinTrack";
            this.xMinTrack.Size = new System.Drawing.Size(160, 45);
            this.xMinTrack.TabIndex = 2;
            this.xMinTrack.TickFrequency = 10;
            this.xMinTrack.Value = -10;
            this.xMinTrack.Scroll += new System.EventHandler(this.XMinTrack_Scroll);
            // 
            // xMinText
            // 
            this.xMinText.Location = new System.Drawing.Point(31, 421);
            this.xMinText.Name = "xMinText";
            this.xMinText.Size = new System.Drawing.Size(100, 20);
            this.xMinText.TabIndex = 3;
            this.xMinText.Text = "-10";
            this.xMinText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xMaxTrack
            // 
            this.xMaxTrack.Location = new System.Drawing.Point(0, 447);
            this.xMaxTrack.Maximum = 100;
            this.xMaxTrack.Minimum = -100;
            this.xMaxTrack.Name = "xMaxTrack";
            this.xMaxTrack.Size = new System.Drawing.Size(160, 45);
            this.xMaxTrack.TabIndex = 2;
            this.xMaxTrack.TickFrequency = 10;
            this.xMaxTrack.Value = 10;
            this.xMaxTrack.Scroll += new System.EventHandler(this.XMaxTrack_Scroll);
            // 
            // xMaxText
            // 
            this.xMaxText.Location = new System.Drawing.Point(31, 474);
            this.xMaxText.Name = "xMaxText";
            this.xMaxText.Size = new System.Drawing.Size(100, 20);
            this.xMaxText.TabIndex = 3;
            this.xMaxText.Text = "10";
            this.xMaxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xIntTrack
            // 
            this.xIntTrack.Location = new System.Drawing.Point(0, 500);
            this.xIntTrack.Maximum = 100;
            this.xIntTrack.Minimum = 1;
            this.xIntTrack.Name = "xIntTrack";
            this.xIntTrack.Size = new System.Drawing.Size(160, 45);
            this.xIntTrack.TabIndex = 2;
            this.xIntTrack.TickFrequency = 10;
            this.xIntTrack.Value = 10;
            this.xIntTrack.Scroll += new System.EventHandler(this.XIntTrack_Scroll);
            // 
            // xIntText
            // 
            this.xIntText.Location = new System.Drawing.Point(31, 527);
            this.xIntText.Name = "xIntText";
            this.xIntText.Size = new System.Drawing.Size(100, 20);
            this.xIntText.TabIndex = 3;
            this.xIntText.Text = "10";
            this.xIntText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yMinTrack
            // 
            this.yMinTrack.Location = new System.Drawing.Point(166, 394);
            this.yMinTrack.Maximum = 100;
            this.yMinTrack.Minimum = -100;
            this.yMinTrack.Name = "yMinTrack";
            this.yMinTrack.Size = new System.Drawing.Size(160, 45);
            this.yMinTrack.TabIndex = 2;
            this.yMinTrack.TickFrequency = 10;
            this.yMinTrack.Value = -10;
            this.yMinTrack.Scroll += new System.EventHandler(this.YMinTrack_Scroll);
            // 
            // yMaxTrack
            // 
            this.yMaxTrack.Location = new System.Drawing.Point(166, 447);
            this.yMaxTrack.Maximum = 100;
            this.yMaxTrack.Minimum = -100;
            this.yMaxTrack.Name = "yMaxTrack";
            this.yMaxTrack.Size = new System.Drawing.Size(160, 45);
            this.yMaxTrack.TabIndex = 2;
            this.yMaxTrack.TickFrequency = 10;
            this.yMaxTrack.Value = 10;
            this.yMaxTrack.Scroll += new System.EventHandler(this.YMaxTrack_Scroll);
            // 
            // YIntTrack
            // 
            this.YIntTrack.Location = new System.Drawing.Point(166, 500);
            this.YIntTrack.Maximum = 100;
            this.YIntTrack.Minimum = 1;
            this.YIntTrack.Name = "YIntTrack";
            this.YIntTrack.Size = new System.Drawing.Size(160, 45);
            this.YIntTrack.TabIndex = 2;
            this.YIntTrack.TickFrequency = 10;
            this.YIntTrack.Value = 10;
            this.YIntTrack.Scroll += new System.EventHandler(this.YIntTrack_Scroll);
            // 
            // yMinText
            // 
            this.yMinText.Location = new System.Drawing.Point(197, 421);
            this.yMinText.Name = "yMinText";
            this.yMinText.Size = new System.Drawing.Size(100, 20);
            this.yMinText.TabIndex = 3;
            this.yMinText.Text = "-10";
            this.yMinText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yMaxText
            // 
            this.yMaxText.Location = new System.Drawing.Point(197, 474);
            this.yMaxText.Name = "yMaxText";
            this.yMaxText.Size = new System.Drawing.Size(100, 20);
            this.yMaxText.TabIndex = 3;
            this.yMaxText.Text = "10";
            this.yMaxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yIntText
            // 
            this.yIntText.Location = new System.Drawing.Point(197, 527);
            this.yIntText.Name = "yIntText";
            this.yIntText.Size = new System.Drawing.Size(100, 20);
            this.yIntText.TabIndex = 3;
            this.yIntText.Text = "10";
            this.yIntText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(717, 761);
            this.Controls.Add(this.yIntText);
            this.Controls.Add(this.xIntText);
            this.Controls.Add(this.yMaxText);
            this.Controls.Add(this.xMaxText);
            this.Controls.Add(this.yMinText);
            this.Controls.Add(this.xMinText);
            this.Controls.Add(this.YIntTrack);
            this.Controls.Add(this.xIntTrack);
            this.Controls.Add(this.yMaxTrack);
            this.Controls.Add(this.xMaxTrack);
            this.Controls.Add(this.yMinTrack);
            this.Controls.Add(this.xMinTrack);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GraphPB);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Graphing Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.GraphPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xIntTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YIntTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GraphPB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TrackBar xMinTrack;
        private System.Windows.Forms.TextBox xMinText;
        private System.Windows.Forms.TrackBar xMaxTrack;
        private System.Windows.Forms.TextBox xMaxText;
        private System.Windows.Forms.TrackBar xIntTrack;
        private System.Windows.Forms.TextBox xIntText;
        private System.Windows.Forms.TrackBar yMinTrack;
        private System.Windows.Forms.TrackBar yMaxTrack;
        private System.Windows.Forms.TrackBar YIntTrack;
        private System.Windows.Forms.TextBox yMinText;
        private System.Windows.Forms.TextBox yMaxText;
        private System.Windows.Forms.TextBox yIntText;
    }
}

