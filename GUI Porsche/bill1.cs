using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Porsche
{
    public partial class bill1 : Form
    {
        public bill1()
        {
            InitializeComponent();
        }

        private void bill1_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = "C:\\Users\\prade\\source\\repos\\GUI Porsche\\GUI Porsche\\CrystalReport1.rpt";
        }
    }
}
