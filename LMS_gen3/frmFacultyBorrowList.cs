using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LMS_gen3
{
    public partial class frmFacultyBorrowList : Form
    {
        public frmFacultyBorrowList()
        {
            InitializeComponent();
        }

        

        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
        SqlDataAdapter sda;
        DataTable dt;

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "insert into FacBorrow (Name,MemberId,Department,Mobile,Email,Material,ISBN,IssueDate,DueDate,Status) values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','"+this.comboBox1.Text+"','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.comboBox2.Text + "','" + this.textBox5.Text + "','" + this.dateTimePicker1.Value + "','" + this.dateTimePicker2.Value + "','" + this.comboBox3.Text + "')";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Data Stored Successfully");
                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Book")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Title, Rack, Self from Books where Title like '%" + textBox6.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox4.Text == "Journal")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Title, Rack, Self from Journals where Title like '%" + textBox6.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFacultyBorrowStatus fbstatus = new frmFacultyBorrowStatus();
            fbstatus.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFacultyBorrowList_Load(object sender, EventArgs e)
        {
            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "update FacBorrow set Name='" + this.textBox1.Text + "',MemberId='" + this.textBox2.Text + "',Department='" + this.comboBox1.Text + "',Mobile='" + this.textBox3.Text + "',Email='" + this.textBox4.Text + "',Material='" + this.comboBox2.Text + "',ISBN='" + this.textBox5.Text + "',IssueDate='" + this.dateTimePicker1.Text + "',DueDate='" + this.dateTimePicker2.Text + "',Status='" + this.comboBox3.Text + "' where MemberId='" + this.textBox2.Text +"' ";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Data Updated Successfully");
                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "delete from FacBorrow where MemberId='" + textBox2.Text+"' ";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Data Deleted Successfully");
                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
