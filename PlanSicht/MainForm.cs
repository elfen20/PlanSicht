using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanSicht
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            splitContainer1.Panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            using (var g = e.Graphics)
            {
                g.FillRectangle(Brushes.Red, new Rectangle(10, 10, 20, 20));
            }
        }
    }
}
