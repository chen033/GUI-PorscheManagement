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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=GADcw; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();  //connection activated

            try
            {
                //sql command "inserting data"
                string sql = "SELECT count(1) FROM signIn WHERE Uname=@Uname AND password=@password";
                //check if data is aligned,,count(1) will return the number of rows that match the condition. If count ==1, means exactly one record with the provided username and password.

                SqlCommand com = new SqlCommand(sql, con); //This class is used to execute a command against a SQL Server database
                com.Parameters.AddWithValue("Uname", this.txtname1.Text);
                com.Parameters.AddWithValue("password", this.txtpass1.Text);

                int count = Convert.ToInt32(com.ExecuteScalar()); //ExecuteScalar executes the query and returns the first column of the first row in the result set, which is the count of matching rows in this case.
                if (count == 1)
                {
                    MessageBox.Show("Log in succesful");
                     this.Hide();
                     order models = new order();
                     models.Show();
                }
                else
                {
                    MessageBox.Show("entered data incorect");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                con.Close();
            }


          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void lbllnkSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp s=new SignUp ();
            s.Show();
        }

        private void linkFpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgtPass f1 = new ForgtPass();
            f1.Show();
        }
    }
}
