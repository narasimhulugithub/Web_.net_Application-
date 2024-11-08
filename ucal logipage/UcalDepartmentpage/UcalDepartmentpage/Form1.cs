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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UcalDepartmentpage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Registrati();
           
        }
        public void Registrati()
        {
            SqlConnection con = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            string sql = "select * from tblDepartments";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreade;

            try
            {
                con.Open();
                myreade = cmd.ExecuteReader();
                while (myreade.Read())
                {
                    string sname = myreade.GetString(2);
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
            string sql = "select * from tblDepartments where Department_Name = '" + comboBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader myreade;
            try
            {
                conn.Open();
                myreade = cmd.ExecuteReader();
                while (myreade.Read())
                {
                    
                    string departmentid = myreade.GetInt32(0).ToString();
                    string division = myreade.GetInt32(1).ToString();
                    string Department = myreade.GetString(2);
                    string description = myreade.GetString(3);
                    string email = myreade.GetString(4);
                    string email2 = myreade.GetString(5);
                    
                    
                    textBox1.Text = departmentid;
                    textBox2.Text = division;
                    textBox3.Text = Department;
                    textBox4.Text = description;
                    textBox5.Text = email;
                    textBox6.Text = email2;
                    



                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("pleace enter the details","info",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string  departmentid,division, departmentname, description, email, email2;

            departmentid=textBox1.Text;
            division = textBox2.Text;
            departmentname = textBox3.Text;
            description = textBox4.Text;
            email = textBox5.Text;
            email2 = textBox6.Text;
            


            //Create connection and open it.

            SqlConnection connn = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            connn.Open();

            //create command object to pass the connection and other information
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connn;

            //set command type as stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            //pass the stored procedure name
            cmd.CommandText = "[dbo].[insedepart]";

            //pass the parameter to stored procedure
            cmd.Parameters.Add(new SqlParameter("@DepartmentID", SqlDbType.Int)).Value = departmentid;
            cmd.Parameters.Add(new SqlParameter("@Division_ID", SqlDbType.Int)).Value =division ;
            cmd.Parameters.Add(new SqlParameter("@Department_Name", SqlDbType.NVarChar)).Value = departmentname;
            cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar)).Value = description;
            cmd.Parameters.Add(new SqlParameter("@Email1_ID", SqlDbType.NVarChar)).Value = email;
            cmd.Parameters.Add(new SqlParameter("@Email2_ID", SqlDbType.NVarChar)).Value = email2;
            
            ////Execute the query

            int res = cmd.ExecuteNonQuery();    
            connn.Close();

            if (res > 0)
            {
                MessageBox.Show("User Registrtion Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("pleace fille the requard details ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
             textBox1.Text = "";
            using (SqlConnection AR = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True"))
            {
                AR.Open();
                String query = "SELECT DepartmentID FROM tblDepartments  ORDER BY [DepartmentID] DESC";
                using (SqlCommand SDA = new SqlCommand(query, AR))
                {
                    SqlDataReader data = SDA.ExecuteReader();
                    if (data.Read())
                    {
                        textBox1.Text = data.GetValue(0).ToString();
                    }
                }
                AR.Close();
            }
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection AR = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True"))
            {
                AR.Open();
                String query = "SELECT DepartmentID FROM tblDepartments  ORDER BY [DepartmentID] DESC";
                using (SqlCommand SDA = new SqlCommand(query, AR))
                {
                    SqlDataReader data = SDA.ExecuteReader();
                    if (data.Read())
                    {
                        textBox1.Text = data.GetValue(0).ToString();
                    }
                }
                AR.Close();
            }
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
        //    SqlConnection A = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
        //    string departmentid, division, departmentname, description, email, email2;

        //    departmentid = textBox1.Text;
        //    division = textBox2.Text;
        //    departmentname = textBox3.Text;
        //    description = textBox4.Text;
        //    email = textBox5.Text;
        //    email2 = textBox6.Text;
            
        //    if (string.IsNullOrEmpty(textBox1.Text))
        //    {
        //        MessageBox.Show("plece enter the Department_ID","info",MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    if (string.IsNullOrEmpty(textBox2.Text))
        //    {
        //        MessageBox.Show("plece enter the Division", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    if (string.IsNullOrEmpty(textBox3.Text))
        //    {
        //        MessageBox.Show("plece enter the Department_Name", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    if (string.IsNullOrEmpty(textBox4.Text))
        //    {
        //        MessageBox.Show("plece enter the Description", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    if (string.IsNullOrEmpty(textBox5.Text))
        //    {
        //        MessageBox.Show("plece enter the Email1_ID", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    if (string.IsNullOrEmpty(textBox6.Text))
        //    {
        //        MessageBox.Show("plece enter the Email2_ID", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
           


           
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = A;

        //        //set command type as stored procedure
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        //pass the stored procedure name
        //        cmd.CommandText = "[dbo].[insedepart]";
        //        cmd = new SqlCommand("update tblDepartments set departmentid=@DepartmentID,division=@Division,departmentname=@Department_Name,description=@Description,email1=@Email1,email2=@email2", A);
        //        A.Open();
                
        //        cmd.Parameters.AddWithValue("@DepartmentID", textBox1.Text);
        //        cmd.Parameters.AddWithValue("@Division", textBox2.Text);
        //        cmd.Parameters.AddWithValue("@Department_Name",textBox3.Text);
        //        cmd.Parameters.AddWithValue("@Email1_ID", textBox5.Text);
        //        cmd.Parameters.AddWithValue("@Email2_ID", textBox6.Text);
        //        cmd.Parameters.AddWithValue("@Description", textBox4.Text);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Record Updated Successfully");
        //        A.Close();
            



        }
    }
}
