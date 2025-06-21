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
    public partial class car1 : Form
    {
        public car1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Models models = new Models();
            models.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1 ();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
