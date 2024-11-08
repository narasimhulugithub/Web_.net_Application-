using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ucal_logipage
{
    public partial class Form3 : Form
    {


        public Form3()
        {

            InitializeComponent();
            fillcombobox();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox3.PasswordChar = checkBox1.Checked? '\0' : '*';
            if (checkBox1.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar= true;
            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, Password;

            username = textBox2.Text;
            Password = textBox3.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");

                //String querry = "select * from user_configuration where username= '" + textBox2.Text + "' and Password='" + textBox3.Text + "'";
                string querry = "select * from tblUserConfiguration where Name = '" + comboBox1.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = textBox2.Text;
                    Password = textBox3.Text;

                    Form2 obj = new Form2();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
               // conn.Close();
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void fillcombobox()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            string sql = "select * from tblUserConfiguration";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader myreader;

            try
            {
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    comboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            string sql = "select * from tblUserConfiguration where Name = '" + comboBox1.Text+"';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader myreader;

            try
            {
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string Username =myreader.GetString(10);
                   
                    textBox2.Text = Username;
                    

                  

                }

            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration obj= new Registration();
            obj.Show();
            this.Hide();
        }
    }
}

    


    

