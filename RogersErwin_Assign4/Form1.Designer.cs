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
            ((System.ComponentModel.ISupportInitialize)(this.GraphPB)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphPB
            // 
            this.GraphPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GraphPB.Location = new System.Drawing.Point(12, 12);
            this.GraphPB.Name = "GraphPB";
            this.GraphPB.Size = new System.Drawing.Size(693, 344);
            this.GraphPB.TabIndex = 0;
            this.GraphPB.TabStop = false;
            this.GraphPB.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPB_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(717, 761);
            this.Controls.Add(this.GraphPB);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Graphing Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.GraphPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GraphPB;
    }
}

