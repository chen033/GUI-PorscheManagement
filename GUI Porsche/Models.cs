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
    public partial class Models : Form
    {
        public Models()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            car1 c1 = new car1();
            c1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            car2 c2 = new car2();
            c2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            car3 c3 = new car3();
            c3.Show();
        }
    }
}
