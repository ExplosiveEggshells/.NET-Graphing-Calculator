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
            this.components = new System.ComponentModel.Container();
            this.GraphPB = new System.Windows.Forms.PictureBox();
            this.LinearLabel = new System.Windows.Forms.Label();
            this.MTextBox = new System.Windows.Forms.TextBox();
            this.CubicButton = new System.Windows.Forms.Button();
            this.MLinearLabel = new System.Windows.Forms.Label();
            this.BLinearLabel = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.QuadLabel = new System.Windows.Forms.Label();
            this.CubicLabel = new System.Windows.Forms.Label();
            this.CircleLabel = new System.Windows.Forms.Label();
            this.AQuadLabel = new System.Windows.Forms.Label();
            this.AQuadTextBox = new System.Windows.Forms.TextBox();
            this.BQuadLabel = new System.Windows.Forms.Label();
            this.BQuadTextBox = new System.Windows.Forms.TextBox();
            this.CQuadTextBox = new System.Windows.Forms.TextBox();
            this.CQuadLabel = new System.Windows.Forms.Label();
            this.BCubicLabel = new System.Windows.Forms.Label();
            this.BCubicTextBox = new System.Windows.Forms.TextBox();
            this.CCubicLabel = new System.Windows.Forms.Label();
            this.ACubicLabel = new System.Windows.Forms.Label();
            this.ACubicTextBox = new System.Windows.Forms.TextBox();
            this.CCubicTextBox = new System.Windows.Forms.TextBox();
            this.DCubicLabel = new System.Windows.Forms.Label();
            this.DCubicTextBox = new System.Windows.Forms.TextBox();
            this.R2TextBox = new System.Windows.Forms.TextBox();
            this.R2CircleLabel = new System.Windows.Forms.Label();
            this.KTextBox = new System.Windows.Forms.TextBox();
            this.KCircleLabel = new System.Windows.Forms.Label();
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.HCircleLabel = new System.Windows.Forms.Label();
            this.QuadButton = new System.Windows.Forms.Button();
            this.LinearButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.XGroupBox = new System.Windows.Forms.GroupBox();
            this.XIntervalLabel = new System.Windows.Forms.Label();
            this.XMaxLabel = new System.Windows.Forms.Label();
            this.XMinLabel = new System.Windows.Forms.Label();
            this.XIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.XMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.XMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YGroupBox = new System.Windows.Forms.GroupBox();
            this.YIntervalLabel = new System.Windows.Forms.Label();
            this.YMaxLabel = new System.Windows.Forms.Label();
            this.YMinLabel = new System.Windows.Forms.Label();
            this.YIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.YMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CircleColorButton = new System.Windows.Forms.Button();
            this.CubicColorButton = new System.Windows.Forms.Button();
            this.LinearColorButton = new System.Windows.Forms.Button();
            this.QuadColorButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CoordinatesButton = new System.Windows.Forms.Button();
            this.LinearColorDialog = new System.Windows.Forms.ColorDialog();
            this.QuadColorDialog = new System.Windows.Forms.ColorDialog();
            this.CubicColorDialog = new System.Windows.Forms.ColorDialog();
            this.CircleColorDialog = new System.Windows.Forms.ColorDialog();
            this.LogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FunctionToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GraphPB)).BeginInit();
            this.XGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMinNumericUpDown)).BeginInit();
            this.YGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YMinNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphPB
            // 
            this.GraphPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GraphPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GraphPB.Location = new System.Drawing.Point(12, 12);
            this.GraphPB.Name = "GraphPB";
            this.GraphPB.Size = new System.Drawing.Size(692, 346);
            this.GraphPB.TabIndex = 0;
            this.GraphPB.TabStop = false;
            this.GraphPB.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPB_Paint);
            // 
            // LinearLabel
            // 
            this.LinearLabel.AutoSize = true;
            this.LinearLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinearLabel.Location = new System.Drawing.Point(6, 16);
            this.LinearLabel.Name = "LinearLabel";
            this.LinearLabel.Size = new System.Drawing.Size(78, 18);
            this.LinearLabel.TabIndex = 9999;
            this.LinearLabel.Text = "Linear:";
            this.LinearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FunctionToolTip.SetToolTip(this.LinearLabel, "y = mx + b");
            // 
            // MTextBox
            // 
            this.MTextBox.BackColor = System.Drawing.Color.Black;
            this.MTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.MTextBox.Location = new System.Drawing.Point(139, 13);
            this.MTextBox.Name = "MTextBox";
            this.MTextBox.Size = new System.Drawing.Size(46, 20);
            this.MTextBox.TabIndex = 0;
            this.MTextBox.Text = "0";
            this.MTextBox.Enter += new System.EventHandler(this.MTextBox_Enter);
            this.MTextBox.Leave += new System.EventHandler(this.MTextBox_Leave);
            // 
            // CubicButton
            // 
            this.CubicButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CubicButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.CubicButton.Location = new System.Drawing.Point(415, 58);
            this.CubicButton.Name = "CubicButton";
            this.CubicButton.Size = new System.Drawing.Size(45, 20);
            this.CubicButton.TabIndex = 6;
            this.CubicButton.TabStop = false;
            this.CubicButton.Text = "Plot";
            this.CubicButton.UseVisualStyleBackColor = false;
            this.CubicButton.Click += new System.EventHandler(this.CubicButton_Click);
            // 
            // MLinearLabel
            // 
            this.MLinearLabel.AutoSize = true;
            this.MLinearLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLinearLabel.Location = new System.Drawing.Point(119, 15);
            this.MLinearLabel.Name = "MLinearLabel";
            this.MLinearLabel.Size = new System.Drawing.Size(18, 18);
            this.MLinearLabel.TabIndex = 7;
            this.MLinearLabel.Text = "m";
            // 
            // BLinearLabel
            // 
            this.BLinearLabel.AutoSize = true;
            this.BLinearLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLinearLabel.Location = new System.Drawing.Point(191, 15);
            this.BLinearLabel.Name = "BLinearLabel";
            this.BLinearLabel.Size = new System.Drawing.Size(18, 18);
            this.BLinearLabel.TabIndex = 8;
            this.BLinearLabel.Text = "b";
            // 
            // BTextBox
            // 
            this.BTextBox.BackColor = System.Drawing.Color.Black;
            this.BTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.BTextBox.Location = new System.Drawing.Point(211, 13);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(46, 20);
            this.BTextBox.TabIndex = 1;
            this.BTextBox.Text = "0";
            this.BTextBox.Enter += new System.EventHandler(this.BTextBox_Enter);
            this.BTextBox.Leave += new System.EventHandler(this.BTextBox_Leave);
            // 
            // QuadLabel
            // 
            this.QuadLabel.AutoSize = true;
            this.QuadLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuadLabel.Location = new System.Drawing.Point(6, 38);
            this.QuadLabel.Name = "QuadLabel";
            this.QuadLabel.Size = new System.Drawing.Size(108, 18);
            this.QuadLabel.TabIndex = 9999;
            this.QuadLabel.Text = "Quadratic:";
            this.QuadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FunctionToolTip.SetToolTip(this.QuadLabel, "y = ax² + bx + c");
            // 
            // CubicLabel
            // 
            this.CubicLabel.AutoSize = true;
            this.CubicLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CubicLabel.Location = new System.Drawing.Point(6, 60);
            this.CubicLabel.Name = "CubicLabel";
            this.CubicLabel.Size = new System.Drawing.Size(68, 18);
            this.CubicLabel.TabIndex = 9999;
            this.CubicLabel.Text = "Cubic:";
            this.CubicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FunctionToolTip.SetToolTip(this.CubicLabel, "y = ax³ + bx² + cx + d");
            // 
            // CircleLabel
            // 
            this.CircleLabel.AutoSize = true;
            this.CircleLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleLabel.Location = new System.Drawing.Point(6, 82);
            this.CircleLabel.Name = "CircleLabel";
            this.CircleLabel.Size = new System.Drawing.Size(78, 18);
            this.CircleLabel.TabIndex = 9999;
            this.CircleLabel.Text = "Circle:";
            this.CircleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FunctionToolTip.SetToolTip(this.CircleLabel, "(x - h)² + (y - k)² = r²");
            // 
            // AQuadLabel
            // 
            this.AQuadLabel.AutoSize = true;
            this.AQuadLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AQuadLabel.Location = new System.Drawing.Point(120, 38);
            this.AQuadLabel.Name = "AQuadLabel";
            this.AQuadLabel.Size = new System.Drawing.Size(17, 17);
            this.AQuadLabel.TabIndex = 13;
            this.AQuadLabel.Text = "a";
            // 
            // AQuadTextBox
            // 
            this.AQuadTextBox.BackColor = System.Drawing.Color.Black;
            this.AQuadTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.AQuadTextBox.Location = new System.Drawing.Point(139, 35);
            this.AQuadTextBox.Name = "AQuadTextBox";
            this.AQuadTextBox.Size = new System.Drawing.Size(46, 20);
            this.AQuadTextBox.TabIndex = 2;
            this.AQuadTextBox.Text = "0";
            this.AQuadTextBox.Enter += new System.EventHandler(this.AQuadTextBox_Enter);
            this.AQuadTextBox.Leave += new System.EventHandler(this.AQuadTextBox_Leave);
            // 
            // BQuadLabel
            // 
            this.BQuadLabel.AutoSize = true;
            this.BQuadLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BQuadLabel.Location = new System.Drawing.Point(191, 37);
            this.BQuadLabel.Name = "BQuadLabel";
            this.BQuadLabel.Size = new System.Drawing.Size(18, 18);
            this.BQuadLabel.TabIndex = 15;
            this.BQuadLabel.Text = "b";
            // 
            // BQuadTextBox
            // 
            this.BQuadTextBox.BackColor = System.Drawing.Color.Black;
            this.BQuadTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.BQuadTextBox.Location = new System.Drawing.Point(211, 35);
            this.BQuadTextBox.Name = "BQuadTextBox";
            this.BQuadTextBox.Size = new System.Drawing.Size(46, 20);
            this.BQuadTextBox.TabIndex = 3;
            this.BQuadTextBox.Text = "0";
            this.BQuadTextBox.Enter += new System.EventHandler(this.BQuadTextBox_Enter);
            this.BQuadTextBox.Leave += new System.EventHandler(this.BQuadTextBox_Leave);
            // 
            // CQuadTextBox
            // 
            this.CQuadTextBox.BackColor = System.Drawing.Color.Black;
            this.CQuadTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.CQuadTextBox.Location = new System.Drawing.Point(287, 35);
            this.CQuadTextBox.Name = "CQuadTextBox";
            this.CQuadTextBox.Size = new System.Drawing.Size(46, 20);
            this.CQuadTextBox.TabIndex = 4;
            this.CQuadTextBox.Text = "0";
            this.CQuadTextBox.Enter += new System.EventHandler(this.CQuadTextBox_Enter);
            this.CQuadTextBox.Leave += new System.EventHandler(this.CQuadTextBox_Leave);
            // 
            // CQuadLabel
            // 
            this.CQuadLabel.AutoSize = true;
            this.CQuadLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CQuadLabel.Location = new System.Drawing.Point(263, 37);
            this.CQuadLabel.Name = "CQuadLabel";
            this.CQuadLabel.Size = new System.Drawing.Size(18, 18);
            this.CQuadLabel.TabIndex = 17;
            this.CQuadLabel.Text = "c";
            // 
            // BCubicLabel
            // 
            this.BCubicLabel.AutoSize = true;
            this.BCubicLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCubicLabel.Location = new System.Drawing.Point(191, 60);
            this.BCubicLabel.Name = "BCubicLabel";
            this.BCubicLabel.Size = new System.Drawing.Size(17, 17);
            this.BCubicLabel.TabIndex = 19;
            this.BCubicLabel.Text = "b";
            // 
            // BCubicTextBox
            // 
            this.BCubicTextBox.BackColor = System.Drawing.Color.Black;
            this.BCubicTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.BCubicTextBox.Location = new System.Drawing.Point(211, 57);
            this.BCubicTextBox.Name = "BCubicTextBox";
            this.BCubicTextBox.Size = new System.Drawing.Size(46, 20);
            this.BCubicTextBox.TabIndex = 6;
            this.BCubicTextBox.Text = "0";
            this.BCubicTextBox.Enter += new System.EventHandler(this.BCubicTextBox_Enter);
            this.BCubicTextBox.Leave += new System.EventHandler(this.BCubicTextBox_Leave);
            // 
            // CCubicLabel
            // 
            this.CCubicLabel.AutoSize = true;
            this.CCubicLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCubicLabel.Location = new System.Drawing.Point(263, 59);
            this.CCubicLabel.Name = "CCubicLabel";
            this.CCubicLabel.Size = new System.Drawing.Size(18, 18);
            this.CCubicLabel.TabIndex = 21;
            this.CCubicLabel.Text = "c";
            // 
            // ACubicLabel
            // 
            this.ACubicLabel.AutoSize = true;
            this.ACubicLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACubicLabel.Location = new System.Drawing.Point(119, 60);
            this.ACubicLabel.Name = "ACubicLabel";
            this.ACubicLabel.Size = new System.Drawing.Size(17, 17);
            this.ACubicLabel.TabIndex = 22;
            this.ACubicLabel.Text = "a";
            // 
            // ACubicTextBox
            // 
            this.ACubicTextBox.BackColor = System.Drawing.Color.Black;
            this.ACubicTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.ACubicTextBox.Location = new System.Drawing.Point(139, 57);
            this.ACubicTextBox.Name = "ACubicTextBox";
            this.ACubicTextBox.Size = new System.Drawing.Size(46, 20);
            this.ACubicTextBox.TabIndex = 5;
            this.ACubicTextBox.Text = "0";
            this.ACubicTextBox.Enter += new System.EventHandler(this.ACubicTextBox_Enter);
            this.ACubicTextBox.Leave += new System.EventHandler(this.ACubicTextBox_Leave);
            // 
            // CCubicTextBox
            // 
            this.CCubicTextBox.BackColor = System.Drawing.Color.Black;
            this.CCubicTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.CCubicTextBox.Location = new System.Drawing.Point(287, 57);
            this.CCubicTextBox.Name = "CCubicTextBox";
            this.CCubicTextBox.Size = new System.Drawing.Size(46, 20);
            this.CCubicTextBox.TabIndex = 7;
            this.CCubicTextBox.Text = "0";
            this.CCubicTextBox.Enter += new System.EventHandler(this.CCubicTextBox_Enter);
            this.CCubicTextBox.Leave += new System.EventHandler(this.CCubicTextBox_Leave);
            // 
            // DCubicLabel
            // 
            this.DCubicLabel.AutoSize = true;
            this.DCubicLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCubicLabel.Location = new System.Drawing.Point(339, 59);
            this.DCubicLabel.Name = "DCubicLabel";
            this.DCubicLabel.Size = new System.Drawing.Size(18, 18);
            this.DCubicLabel.TabIndex = 25;
            this.DCubicLabel.Text = "d";
            // 
            // DCubicTextBox
            // 
            this.DCubicTextBox.BackColor = System.Drawing.Color.Black;
            this.DCubicTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.DCubicTextBox.Location = new System.Drawing.Point(363, 57);
            this.DCubicTextBox.Name = "DCubicTextBox";
            this.DCubicTextBox.Size = new System.Drawing.Size(46, 20);
            this.DCubicTextBox.TabIndex = 8;
            this.DCubicTextBox.Text = "0";
            this.DCubicTextBox.Enter += new System.EventHandler(this.DCubicTextBox_Enter);
            this.DCubicTextBox.Leave += new System.EventHandler(this.DCubicTextBox_Leave);
            // 
            // R2TextBox
            // 
            this.R2TextBox.BackColor = System.Drawing.Color.Black;
            this.R2TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.R2TextBox.Location = new System.Drawing.Point(287, 80);
            this.R2TextBox.Name = "R2TextBox";
            this.R2TextBox.Size = new System.Drawing.Size(46, 20);
            this.R2TextBox.TabIndex = 11;
            this.R2TextBox.Text = "1";
            this.R2TextBox.Enter += new System.EventHandler(this.R2TextBox_Enter);
            this.R2TextBox.Leave += new System.EventHandler(this.R2TextBox_Leave);
            // 
            // R2CircleLabel
            // 
            this.R2CircleLabel.AutoSize = true;
            this.R2CircleLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2CircleLabel.Location = new System.Drawing.Point(263, 82);
            this.R2CircleLabel.Name = "R2CircleLabel";
            this.R2CircleLabel.Size = new System.Drawing.Size(18, 18);
            this.R2CircleLabel.TabIndex = 31;
            this.R2CircleLabel.Text = "r";
            // 
            // KTextBox
            // 
            this.KTextBox.BackColor = System.Drawing.Color.Black;
            this.KTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.KTextBox.Location = new System.Drawing.Point(211, 80);
            this.KTextBox.Name = "KTextBox";
            this.KTextBox.Size = new System.Drawing.Size(46, 20);
            this.KTextBox.TabIndex = 10;
            this.KTextBox.Text = "0";
            this.KTextBox.Enter += new System.EventHandler(this.KTextBox_Enter);
            this.KTextBox.Leave += new System.EventHandler(this.KTextBox_Leave);
            // 
            // KCircleLabel
            // 
            this.KCircleLabel.AutoSize = true;
            this.KCircleLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KCircleLabel.Location = new System.Drawing.Point(191, 82);
            this.KCircleLabel.Name = "KCircleLabel";
            this.KCircleLabel.Size = new System.Drawing.Size(18, 18);
            this.KCircleLabel.TabIndex = 29;
            this.KCircleLabel.Text = "k";
            // 
            // HTextBox
            // 
            this.HTextBox.BackColor = System.Drawing.Color.Black;
            this.HTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.HTextBox.Location = new System.Drawing.Point(139, 80);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(46, 20);
            this.HTextBox.TabIndex = 9;
            this.HTextBox.Text = "0";
            this.HTextBox.Enter += new System.EventHandler(this.HTextBox_Enter);
            this.HTextBox.Leave += new System.EventHandler(this.HTextBox_Leave);
            // 
            // HCircleLabel
            // 
            this.HCircleLabel.AutoSize = true;
            this.HCircleLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HCircleLabel.Location = new System.Drawing.Point(120, 83);
            this.HCircleLabel.Name = "HCircleLabel";
            this.HCircleLabel.Size = new System.Drawing.Size(17, 17);
            this.HCircleLabel.TabIndex = 27;
            this.HCircleLabel.Text = "h";
            // 
            // QuadButton
            // 
            this.QuadButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuadButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.QuadButton.Location = new System.Drawing.Point(415, 36);
            this.QuadButton.Name = "QuadButton";
            this.QuadButton.Size = new System.Drawing.Size(45, 20);
            this.QuadButton.TabIndex = 33;
            this.QuadButton.TabStop = false;
            this.QuadButton.Text = "Plot";
            this.QuadButton.UseVisualStyleBackColor = false;
            this.QuadButton.Click += new System.EventHandler(this.QuadButton_Click);
            // 
            // LinearButton
            // 
            this.LinearButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LinearButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.LinearButton.Location = new System.Drawing.Point(415, 14);
            this.LinearButton.Name = "LinearButton";
            this.LinearButton.Size = new System.Drawing.Size(45, 20);
            this.LinearButton.TabIndex = 34;
            this.LinearButton.TabStop = false;
            this.LinearButton.Text = "Plot";
            this.LinearButton.UseVisualStyleBackColor = false;
            this.LinearButton.Click += new System.EventHandler(this.LinearButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CircleButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.CircleButton.Location = new System.Drawing.Point(415, 80);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(45, 20);
            this.CircleButton.TabIndex = 35;
            this.CircleButton.TabStop = false;
            this.CircleButton.Text = "Plot";
            this.CircleButton.UseVisualStyleBackColor = false;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // XGroupBox
            // 
            this.XGroupBox.Controls.Add(this.XIntervalLabel);
            this.XGroupBox.Controls.Add(this.XMaxLabel);
            this.XGroupBox.Controls.Add(this.XMinLabel);
            this.XGroupBox.Controls.Add(this.XIntervalNumericUpDown);
            this.XGroupBox.Controls.Add(this.XMaxNumericUpDown);
            this.XGroupBox.Controls.Add(this.XMinNumericUpDown);
            this.XGroupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.XGroupBox.Location = new System.Drawing.Point(103, 19);
            this.XGroupBox.Name = "XGroupBox";
            this.XGroupBox.Size = new System.Drawing.Size(156, 100);
            this.XGroupBox.TabIndex = 36;
            this.XGroupBox.TabStop = false;
            this.XGroupBox.Text = "X options";
            // 
            // XIntervalLabel
            // 
            this.XIntervalLabel.AutoSize = true;
            this.XIntervalLabel.Location = new System.Drawing.Point(11, 73);
            this.XIntervalLabel.Name = "XIntervalLabel";
            this.XIntervalLabel.Size = new System.Drawing.Size(42, 14);
            this.XIntervalLabel.TabIndex = 37;
            this.XIntervalLabel.Text = "X Int";
            // 
            // XMaxLabel
            // 
            this.XMaxLabel.AutoSize = true;
            this.XMaxLabel.Location = new System.Drawing.Point(11, 47);
            this.XMaxLabel.Name = "XMaxLabel";
            this.XMaxLabel.Size = new System.Drawing.Size(42, 14);
            this.XMaxLabel.TabIndex = 4;
            this.XMaxLabel.Text = "X Max";
            // 
            // XMinLabel
            // 
            this.XMinLabel.AutoSize = true;
            this.XMinLabel.Location = new System.Drawing.Point(11, 21);
            this.XMinLabel.Name = "XMinLabel";
            this.XMinLabel.Size = new System.Drawing.Size(42, 14);
            this.XMinLabel.TabIndex = 3;
            this.XMinLabel.Text = "X Min";
            // 
            // XIntervalNumericUpDown
            // 
            this.XIntervalNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.XIntervalNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.XIntervalNumericUpDown.Location = new System.Drawing.Point(81, 71);
            this.XIntervalNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.XIntervalNumericUpDown.Name = "XIntervalNumericUpDown";
            this.XIntervalNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.XIntervalNumericUpDown.TabIndex = 14;
            this.XIntervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // XMaxNumericUpDown
            // 
            this.XMaxNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.XMaxNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.XMaxNumericUpDown.Location = new System.Drawing.Point(81, 45);
            this.XMaxNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.XMaxNumericUpDown.Name = "XMaxNumericUpDown";
            this.XMaxNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.XMaxNumericUpDown.TabIndex = 13;
            this.XMaxNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // XMinNumericUpDown
            // 
            this.XMinNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.XMinNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.XMinNumericUpDown.Location = new System.Drawing.Point(81, 19);
            this.XMinNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.XMinNumericUpDown.Name = "XMinNumericUpDown";
            this.XMinNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.XMinNumericUpDown.TabIndex = 12;
            this.XMinNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // YGroupBox
            // 
            this.YGroupBox.Controls.Add(this.YIntervalLabel);
            this.YGroupBox.Controls.Add(this.YMaxLabel);
            this.YGroupBox.Controls.Add(this.YMinLabel);
            this.YGroupBox.Controls.Add(this.YIntervalNumericUpDown);
            this.YGroupBox.Controls.Add(this.YMaxNumericUpDown);
            this.YGroupBox.Controls.Add(this.YMinNumericUpDown);
            this.YGroupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.YGroupBox.Location = new System.Drawing.Point(268, 19);
            this.YGroupBox.Name = "YGroupBox";
            this.YGroupBox.Size = new System.Drawing.Size(156, 100);
            this.YGroupBox.TabIndex = 38;
            this.YGroupBox.TabStop = false;
            this.YGroupBox.Text = "Y options";
            // 
            // YIntervalLabel
            // 
            this.YIntervalLabel.AutoSize = true;
            this.YIntervalLabel.Location = new System.Drawing.Point(11, 73);
            this.YIntervalLabel.Name = "YIntervalLabel";
            this.YIntervalLabel.Size = new System.Drawing.Size(42, 14);
            this.YIntervalLabel.TabIndex = 37;
            this.YIntervalLabel.Text = "Y Int";
            // 
            // YMaxLabel
            // 
            this.YMaxLabel.AutoSize = true;
            this.YMaxLabel.Location = new System.Drawing.Point(11, 47);
            this.YMaxLabel.Name = "YMaxLabel";
            this.YMaxLabel.Size = new System.Drawing.Size(42, 14);
            this.YMaxLabel.TabIndex = 4;
            this.YMaxLabel.Text = "Y Max";
            // 
            // YMinLabel
            // 
            this.YMinLabel.AutoSize = true;
            this.YMinLabel.Location = new System.Drawing.Point(11, 21);
            this.YMinLabel.Name = "YMinLabel";
            this.YMinLabel.Size = new System.Drawing.Size(42, 14);
            this.YMinLabel.TabIndex = 3;
            this.YMinLabel.Text = "Y Min";
            // 
            // YIntervalNumericUpDown
            // 
            this.YIntervalNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.YIntervalNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.YIntervalNumericUpDown.Location = new System.Drawing.Point(81, 71);
            this.YIntervalNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.YIntervalNumericUpDown.Name = "YIntervalNumericUpDown";
            this.YIntervalNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.YIntervalNumericUpDown.TabIndex = 17;
            this.YIntervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // YMaxNumericUpDown
            // 
            this.YMaxNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.YMaxNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.YMaxNumericUpDown.Location = new System.Drawing.Point(81, 45);
            this.YMaxNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.YMaxNumericUpDown.Name = "YMaxNumericUpDown";
            this.YMaxNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.YMaxNumericUpDown.TabIndex = 16;
            this.YMaxNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // YMinNumericUpDown
            // 
            this.YMinNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.YMinNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.YMinNumericUpDown.Location = new System.Drawing.Point(81, 19);
            this.YMinNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.YMinNumericUpDown.Name = "YMinNumericUpDown";
            this.YMinNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.YMinNumericUpDown.TabIndex = 15;
            this.YMinNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.CircleColorButton);
            this.groupBox1.Controls.Add(this.CubicColorButton);
            this.groupBox1.Controls.Add(this.LinearColorButton);
            this.groupBox1.Controls.Add(this.QuadColorButton);
            this.groupBox1.Controls.Add(this.CircleLabel);
            this.groupBox1.Controls.Add(this.LinearLabel);
            this.groupBox1.Controls.Add(this.MTextBox);
            this.groupBox1.Controls.Add(this.CircleButton);
            this.groupBox1.Controls.Add(this.CubicButton);
            this.groupBox1.Controls.Add(this.LinearButton);
            this.groupBox1.Controls.Add(this.MLinearLabel);
            this.groupBox1.Controls.Add(this.QuadButton);
            this.groupBox1.Controls.Add(this.BLinearLabel);
            this.groupBox1.Controls.Add(this.R2TextBox);
            this.groupBox1.Controls.Add(this.BTextBox);
            this.groupBox1.Controls.Add(this.R2CircleLabel);
            this.groupBox1.Controls.Add(this.QuadLabel);
            this.groupBox1.Controls.Add(this.KTextBox);
            this.groupBox1.Controls.Add(this.CubicLabel);
            this.groupBox1.Controls.Add(this.KCircleLabel);
            this.groupBox1.Controls.Add(this.AQuadLabel);
            this.groupBox1.Controls.Add(this.HTextBox);
            this.groupBox1.Controls.Add(this.AQuadTextBox);
            this.groupBox1.Controls.Add(this.HCircleLabel);
            this.groupBox1.Controls.Add(this.BQuadLabel);
            this.groupBox1.Controls.Add(this.DCubicTextBox);
            this.groupBox1.Controls.Add(this.BQuadTextBox);
            this.groupBox1.Controls.Add(this.DCubicLabel);
            this.groupBox1.Controls.Add(this.CQuadLabel);
            this.groupBox1.Controls.Add(this.CCubicTextBox);
            this.groupBox1.Controls.Add(this.CQuadTextBox);
            this.groupBox1.Controls.Add(this.ACubicTextBox);
            this.groupBox1.Controls.Add(this.BCubicLabel);
            this.groupBox1.Controls.Add(this.ACubicLabel);
            this.groupBox1.Controls.Add(this.BCubicTextBox);
            this.groupBox1.Controls.Add(this.CCubicLabel);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(87, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 109);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // CircleColorButton
            // 
            this.CircleColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CircleColorButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.CircleColorButton.Location = new System.Drawing.Point(466, 80);
            this.CircleColorButton.Name = "CircleColorButton";
            this.CircleColorButton.Size = new System.Drawing.Size(50, 20);
            this.CircleColorButton.TabIndex = 39;
            this.CircleColorButton.TabStop = false;
            this.CircleColorButton.Text = "Color";
            this.CircleColorButton.UseVisualStyleBackColor = false;
            this.CircleColorButton.Click += new System.EventHandler(this.CircleColorButton_Click);
            // 
            // CubicColorButton
            // 
            this.CubicColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CubicColorButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.CubicColorButton.Location = new System.Drawing.Point(466, 58);
            this.CubicColorButton.Name = "CubicColorButton";
            this.CubicColorButton.Size = new System.Drawing.Size(50, 20);
            this.CubicColorButton.TabIndex = 36;
            this.CubicColorButton.TabStop = false;
            this.CubicColorButton.Text = "Color";
            this.CubicColorButton.UseVisualStyleBackColor = false;
            this.CubicColorButton.Click += new System.EventHandler(this.CubicColorButton_Click);
            // 
            // LinearColorButton
            // 
            this.LinearColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LinearColorButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.LinearColorButton.Location = new System.Drawing.Point(466, 14);
            this.LinearColorButton.Name = "LinearColorButton";
            this.LinearColorButton.Size = new System.Drawing.Size(50, 20);
            this.LinearColorButton.TabIndex = 38;
            this.LinearColorButton.TabStop = false;
            this.LinearColorButton.Text = "Color";
            this.LinearColorButton.UseVisualStyleBackColor = false;
            this.LinearColorButton.Click += new System.EventHandler(this.LinearColorButton_Click);
            // 
            // QuadColorButton
            // 
            this.QuadColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuadColorButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.QuadColorButton.Location = new System.Drawing.Point(466, 36);
            this.QuadColorButton.Name = "QuadColorButton";
            this.QuadColorButton.Size = new System.Drawing.Size(50, 20);
            this.QuadColorButton.TabIndex = 37;
            this.QuadColorButton.TabStop = false;
            this.QuadColorButton.Text = "Color";
            this.QuadColorButton.UseVisualStyleBackColor = false;
            this.QuadColorButton.Click += new System.EventHandler(this.QuadColorButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CoordinatesButton);
            this.groupBox2.Controls.Add(this.YGroupBox);
            this.groupBox2.Controls.Add(this.XGroupBox);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(87, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 155);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Coordinates";
            // 
            // CoordinatesButton
            // 
            this.CoordinatesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CoordinatesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CoordinatesButton.Location = new System.Drawing.Point(225, 125);
            this.CoordinatesButton.Name = "CoordinatesButton";
            this.CoordinatesButton.Size = new System.Drawing.Size(75, 23);
            this.CoordinatesButton.TabIndex = 39;
            this.CoordinatesButton.Text = "Set";
            this.CoordinatesButton.UseVisualStyleBackColor = false;
            this.CoordinatesButton.Click += new System.EventHandler(this.CoordinatesButton_Click);
            // 
            // LogRichTextBox
            // 
            this.LogRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LogRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogRichTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogRichTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LogRichTextBox.Location = new System.Drawing.Point(12, 660);
            this.LogRichTextBox.Name = "LogRichTextBox";
            this.LogRichTextBox.ReadOnly = true;
            this.LogRichTextBox.Size = new System.Drawing.Size(693, 122);
            this.LogRichTextBox.TabIndex = 41;
            this.LogRichTextBox.Text = "Function results will be displayed here\n";
            this.LogRichTextBox.TextChanged += new System.EventHandler(this.LogRichTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Log";
            // 
            // FunctionToolTip
            // 
            this.FunctionToolTip.BackColor = System.Drawing.SystemColors.InfoText;
            this.FunctionToolTip.ForeColor = System.Drawing.Color.White;
            this.FunctionToolTip.Tag = "";
            this.FunctionToolTip.ToolTipTitle = "Equation Formula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(717, 794);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogRichTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GraphPB);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "                            ";
            ((System.ComponentModel.ISupportInitialize)(this.GraphPB)).EndInit();
            this.XGroupBox.ResumeLayout(false);
            this.XGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XMinNumericUpDown)).EndInit();
            this.YGroupBox.ResumeLayout(false);
            this.YGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YMinNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GraphPB;

        private System.Windows.Forms.Label LinearLabel;
        private System.Windows.Forms.TextBox MTextBox;
        private System.Windows.Forms.Button CubicButton;
        private System.Windows.Forms.Label MLinearLabel;
        private System.Windows.Forms.Label BLinearLabel;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label QuadLabel;
        private System.Windows.Forms.Label CubicLabel;
        private System.Windows.Forms.Label CircleLabel;
        private System.Windows.Forms.Label AQuadLabel;
        private System.Windows.Forms.TextBox AQuadTextBox;
        private System.Windows.Forms.Label BQuadLabel;
        private System.Windows.Forms.TextBox BQuadTextBox;
        private System.Windows.Forms.TextBox CQuadTextBox;
        private System.Windows.Forms.Label CQuadLabel;
        private System.Windows.Forms.Label BCubicLabel;
        private System.Windows.Forms.TextBox BCubicTextBox;
        private System.Windows.Forms.Label CCubicLabel;
        private System.Windows.Forms.Label ACubicLabel;
        private System.Windows.Forms.TextBox ACubicTextBox;
        private System.Windows.Forms.TextBox CCubicTextBox;
        private System.Windows.Forms.Label DCubicLabel;
        private System.Windows.Forms.TextBox DCubicTextBox;
        private System.Windows.Forms.TextBox R2TextBox;
        private System.Windows.Forms.Label R2CircleLabel;
        private System.Windows.Forms.TextBox KTextBox;
        private System.Windows.Forms.Label KCircleLabel;
        private System.Windows.Forms.TextBox HTextBox;
        private System.Windows.Forms.Label HCircleLabel;
        private System.Windows.Forms.Button QuadButton;
        private System.Windows.Forms.Button LinearButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.GroupBox XGroupBox;
        private System.Windows.Forms.Label XIntervalLabel;
        private System.Windows.Forms.Label XMaxLabel;
        private System.Windows.Forms.Label XMinLabel;
        private System.Windows.Forms.NumericUpDown XIntervalNumericUpDown;
        private System.Windows.Forms.NumericUpDown XMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown XMinNumericUpDown;
        private System.Windows.Forms.GroupBox YGroupBox;
        private System.Windows.Forms.Label YIntervalLabel;
        private System.Windows.Forms.Label YMaxLabel;
        private System.Windows.Forms.Label YMinLabel;
        private System.Windows.Forms.NumericUpDown YIntervalNumericUpDown;
        private System.Windows.Forms.NumericUpDown YMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown YMinNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CircleColorButton;
        private System.Windows.Forms.Button CubicColorButton;
        private System.Windows.Forms.Button LinearColorButton;
        private System.Windows.Forms.Button QuadColorButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CoordinatesButton;
        private System.Windows.Forms.ColorDialog LinearColorDialog;
        private System.Windows.Forms.ColorDialog QuadColorDialog;
        private System.Windows.Forms.ColorDialog CubicColorDialog;
        private System.Windows.Forms.ColorDialog CircleColorDialog;
        private System.Windows.Forms.RichTextBox LogRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip FunctionToolTip;
    }
}

