using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ucal_logipage
{

    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
            
            Registratio();
            Registrati();
            Registrat();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            string sql = "select * from tblUserConfiguration where Name = '" + comboBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader myreader;

            try
            {
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string userid = myreader.GetInt32(0).ToString();
                    string name = myreader.GetString(1);
                    string Designation = myreader.GetString(2);
                    string Department = myreader.GetInt32(3).ToString();
                    string qualification = myreader.GetString(4);
                    string Email=myreader.GetString(5);
                    string Hire=myreader.GetSqlDateTime(6).ToString();
                    string TerminationDate = myreader.GetSqlDateTime(7).ToString();
                    string hiretype = myreader.GetString(8);
                    string permissionID = myreader.GetInt32(9).ToString();
                    string Username=myreader.GetString(10);
                    string Password=myreader.GetString(11);
                    string Status=myreader.GetString(12);
                    
                    textBox1.Text = userid;
                    textBox2.Text = name;
                    textBox3.Text = Designation;
                    comboBox2.Text = Department;
                    textBox4.Text = qualification;
                    dateTimePicker1.Text = Hire;
                    textBox5.Text = Email;
                 
                    dateTimePicker2.Text = TerminationDate;
                    comboBox3.Text = hiretype;
                    comboBox4.Text = permissionID;
                    textBox6.Text = Username;
                    textBox7.Text = Password;
                    comboBox5.Text = Status;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            using (SqlConnection AR = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True"))
            {
                AR.Open();
                String query = "SELECT User_ID FROM tblUserConfiguration ORDER BY [User_ID] DESC";
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
        public void Registratio()
        {
            SqlConnection con = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            string sql = "select * from tblUserConfiguration";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;

            try
            {
                con.Open();
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

        private void button1_Click(object sender, EventArgs e)
        {

            //SqlConnection conn = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            //try
            //{

            //    conn.Open();

            //    // Query to join Employee and Department tables
            //    string queryq = @"
            //            SELECT Department_ID,Department_Name 
            //            FROM tblDepartments
            //            JOIN tblUserConfiguration ON DepartmentID  = User_ID";

            //    SqlCommand cmd1 = new SqlCommand(queryq, conn);
            //    SqlDataReader myReader1;

            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(queryq, conn);
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);

            //    // Bind the data to the DataGridView


            //    myReader1 = cmd1.ExecuteReader();
            //    MessageBox.Show("saved");
            //    while (myReader1.Read())
            //    {
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally { conn.Close(); }


            string userid, Name, Designation, Department_ID, Qualification, email, hiredate, terminationdate, hiretype, permissionid, username, password, status;

            userid = textBox1.Text;
            Name = textBox2.Text;
            Designation = textBox3.Text;
            Department_ID = comboBox2.Text;
            Qualification = dateTimePicker1.Text; ;
            email = textBox5.Text;
            hiredate = dateTimePicker2.Text;
            terminationdate = comboBox3.Text;
            hiretype = comboBox5.Text;
            permissionid = textBox6.Text;
            username = textBox6.Text;
            password = textBox7.Text;
            status = comboBox4.Text;

            SqlConnection con = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            string query = "insert into tblUserConfiguration(User_ID,Name,Designation,Department_ID," +
                "Qualification,Email,Hire_Date,Termination_Date,Hire_Type,Permission_ID," +
                "Username,Password,Status)" + "values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.comboBox2.Text + "','" + this.dateTimePicker1.Text + "','" +
                this.textBox5.Text + "','" + this.dateTimePicker2.Text + "','" + this.comboBox3.Text + "','" + this.comboBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.comboBox4.Text + "')  ;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("saved");
                while (myReader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }




        }
        

        private void button2_Click(object sender, EventArgs e)
        {
           // textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            dateTimePicker1.Text = "";
            textBox5.Text = "";
            dateTimePicker2.Text = "";
            comboBox3.Text = "";
            comboBox5.Text = "";
            textBox6.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox4.Text = "";

            using (SqlConnection AR = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True"))
            {
                AR.Open();
                String query = "SELECT User_ID FROM tblUserConfiguration ORDER BY [User_ID] DESC";
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
            Form3 OBJ= new Form3();
            OBJ.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
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
                    comboBox2.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            string sql = "select * from tblDepartments where Department_Name = '" + comboBox2.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreade;
            try
            {
                con.Open();
                myreade = cmd.ExecuteReader();
                while (myreade.Read())
                {
                    string departmentid = myreade.GetInt32(0).ToString();
                    string division = myreade.GetInt32(1).ToString();
                    string Department = myreade.GetString(2);
                    string description = myreade.GetString(3);
                    string email = myreade.GetString(4);
                    string email2 = myreade.GetString(5);
                  

                    //comboBox2.Text = Department;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            SqlConnection conn = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            try
            {

                conn.Open();

                // Query to join Employee and Department tables
                string queryq = @"
                        SELECT Department_ID,Department_Name 
                        FROM tblDepartments
                        JOIN tblUserConfiguration ON DepartmentID  = User_ID";

                SqlCommand cmd1 = new SqlCommand(queryq, conn);
                SqlDataReader myReader1;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryq, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the data to the DataGridView


                myReader1 = cmd1.ExecuteReader();
                MessageBox.Show("saved");
                while (myReader1.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        }

        public void Registrat()
        {
            SqlConnection con = new SqlConnection(@"Data Source=AL75;Initial Catalog=belpk; User ID=sa;password=Nara@76763; Integrated Security=True");
            string sql = "select * from tblPermissionMaster";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreade;

            try
            {
                con.Open();
                myreade = cmd.ExecuteReader();
                while (myreade.Read())
                {
                    string sname = myreade.GetString(1);
                    comboBox5.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox3.PasswordChar = checkBox1.Checked? '\0' : '*';
            if (checkBox1.Checked == true)
            {
                textBox7.UseSystemPasswordChar = false;
            }
            else
            {
                textBox7.UseSystemPasswordChar = true;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             
        }
            
    }
}
