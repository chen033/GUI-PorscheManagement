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
    public partial class SignUp : Form
    {
        public SignUp()
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

        private void btnAccCrt_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=GADcw; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();  //connection activated

            //sql command "inserting data"
            string sql = "INSERT INTO signIn (Uname,email,password) VALUES(@Uname,@email,@password)";

            SqlCommand com = new SqlCommand(sql, con); //This class is used to execute a command against a SQL Server database
            com.Parameters.AddWithValue("Uname", this.txtname2.Text);
            com.Parameters.AddWithValue("email", this.txtMail1.Text);
            com.Parameters.AddWithValue("password", this.txtpass2.Text);

            try
            {
                int ret = com.ExecuteNonQuery();  // Executes the INSERT command. 
                if (ret == 1)  // If one row was successfully inserted,
                {
                    MessageBox.Show("Data successfully added.");
                    this.Hide();
                   order f2 = new order();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Data not added. Please check back!");
                }
            }
            catch (Exception ex)  // Exception occurs, it is caught, and an error message is displayed.
            {
                MessageBox.Show("Error: Failed to add data. " + ex.Message);
            }
        }
    }
}
