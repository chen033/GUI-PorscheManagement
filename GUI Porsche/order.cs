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
    public partial class order : Form
    {
        double total = 0, price = 0;
        int col, tel;
        public order()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void order_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                price = 120000;

             }
            else if(this.comboBox1.SelectedIndex == 1)
                {
                price = 76800;
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                price = 84700;
            }

            this.txtTotal.Text = price.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox2.SelectedIndex == 1)
            {
                col = 650;
            }
          else if (this.comboBox2.SelectedIndex == 2)
            {
                col = 2850;
            }
            total=col+price;
            this.txtTotal.Text = total.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            bill1 b1 = new bill1();
            b1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Models models = new Models();
            models.Show();
        }

        private void btnPurch_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-8TNGUHH5; Initial Catalog=GADcw; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);  //connection string
            con.Open();  //connection activated

            //sql command "inserting data"
            string sql = "INSERT INTO  MyOrder (name,address,model,tel,color,cost) VALUES(@name,@address,@model,@tel,@color,@cost)";

            SqlCommand com = new SqlCommand(sql, con); //This class is used to execute a command against a SQL Server database
            com.Parameters.AddWithValue("name", this.txtName.Text);
            com.Parameters.AddWithValue("address", this.txtAdd.Text);
            com.Parameters.AddWithValue("model", this.comboBox1.Text);
            com.Parameters.AddWithValue("tel", this.txtTel.Text);
            com.Parameters.AddWithValue("color", this.comboBox2.Text);
            com.Parameters.AddWithValue("cost", this.txtTotal.Text);

            try
            {
                int ret = com.ExecuteNonQuery();  // Executes the INSERT command. 
                if (ret == 1)  // If one row was successfully inserted,
                {

                     MessageBox.Show("Do you want to proceed with the purchase?", "Confirm Purchase"); 
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
            con.Close();







        }
    }
}
