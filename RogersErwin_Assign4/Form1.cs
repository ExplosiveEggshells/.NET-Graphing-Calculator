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
            graphParams = new GraphParamsObj(ref GraphPB, -100, 100, 10, -100, 100, 10);
            jarDriver = new JARDriver(ref graphParams, ref GraphPB, ref richTextBox1);
        }

        private void GraphPB_Paint(object sender, PaintEventArgs e)
        {
            if (jarDriver == null) return;
            jarDriver.PaintGraph(sender, e);
        }
    }
}
