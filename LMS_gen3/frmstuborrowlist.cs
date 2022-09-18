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
    public partial class frmstuborrowlist : Form
    {
        public frmstuborrowlist()
        {
            InitializeComponent();
           
        }

        
        SqlConnection con = new SqlConnection(LMS_gen3.Properties.Settings.Default.Connection);
        SqlDataAdapter sda;
        DataTable dt;
       
        private void btnShow_Click(object sender, EventArgs e)
        {
            frmStuBorrowStatus sbstatus = new frmStuBorrowStatus();
            sbstatus.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "update StuBorrow set Id='" + this.comboBox3.Text + "',isbn='" + this.textBox2.Text + "',IssueDate='" + this.dateTimePicker1.Value + "',DueDate='" + this.dateTimePicker2.Value + "',Status='" + this.comboBox2.Text + "',Department='" + this.comboBox1.Text + "',Name='" + this.textBox2.Text + "' where Id='" + this.comboBox3.Text + "' ";
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

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "insert into StuBorrow (Id,isbn,IssueDate,DueDate,Status,Department,Name) values ('" + this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.dateTimePicker1.Value + "','" + this.dateTimePicker2.Value + "','" + this.comboBox2.Text + "','" + this.comboBox1.Text + "','" + this.textBox2.Text + "' )";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "delete from Stuborrow where Id='" + this.comboBox3.Text + "' ";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmstuborrowlist_Load(object sender, EventArgs e)
        {
            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                btnDelete.Enabled = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text=="CSE")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Title, Rack, Self from Books where Category like '%"+comboBox3.Text+"%' and Title like '%"+textBox4.Text+"%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBookInfo.DataSource = dt;
            }
            else if (comboBox3.Text=="EEE")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Title, Rack, Self from Books where Category like '%" + comboBox3.Text + "%' and Title like '%" + textBox4.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBookInfo.DataSource = dt;
            }
            else if (comboBox3.Text=="ME")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Title, Rack, Self from Books where Category like '%" + comboBox3.Text + "%' and Title like '%" + textBox4.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBookInfo.DataSource = dt;
            }
            if (comboBox3.Text == "CE")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Title, Rack, Self from Books where Category like '%" + comboBox3.Text + "%' and Title like '%" + textBox4.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBookInfo.DataSource = dt;
            }
            if (comboBox3.Text == "BBA")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Title, Rack, Self from Books where Category like '%" + comboBox3.Text + "%' and Title like '%" + textBox4.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBookInfo.DataSource = dt;
            }
            if (comboBox3.Text == "BATHM")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Title, Rack, Self from Books where Category like '%" + comboBox3.Text + "%' and Title like '%" + textBox4.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBookInfo.DataSource = dt;
            }

        }
    }
}
