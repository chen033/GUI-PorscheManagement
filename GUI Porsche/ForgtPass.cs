using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Porsche
{
    public partial class ForgtPass : Form
    {
        public ForgtPass()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void lblLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();   
            form.Show();
        }

        private void btnRePass_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=GADcw; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();


            string sql = "SELECT password FROM signIn WHERE email=@email";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@email", this.txtMail3.Text);

            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read(); //the data in the txt will take the pwd of the item and sent it to the price area

            this.txtpass3.Text = rd.GetValue(0).ToString();
            con.Close();
        }
    }
}
