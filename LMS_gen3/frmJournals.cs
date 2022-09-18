using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS_gen3
{
    public partial class frmJournals : Form
    {
        public frmJournals()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommandBuilder builder;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "insert into Journals (Title,isbn,Issue,Series,Price,DOP,Rack,Self) values ('" + textBox2.Text + "','" + textBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.dateTimePicker1.Text + "','"+this.textBox6.Text+"','"+this.textBox7.Text+"')";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "update Journals set title='" + this.textBox2.Text + "',isbn='" + this.textBox1.Text + "',issue='" + this.textBox3.Text + "',Series='" + this.textBox4.Text + "',Price='" + this.textBox5.Text + "',DOP='" + this.dateTimePicker1.Text + "',Rack='"+this.textBox6.Text+"',Self='"+this.textBox7.Text+"' where isbn='"+this.textBox1.Text+"' ";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "delete from Journals where isbn='" + this.textBox1.Text + "' ";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Data deleted Successfully");
                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "select * from Journals"; //changing  * to different column name will show that values only
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmJournals_Load(object sender, EventArgs e)
        {
            string sql = "select * from Journals";
            ds = new DataSet();
            sda = new SqlDataAdapter(sql, con);
            sda.Fill(ds);
            builder = new SqlCommandBuilder(sda);
            dataGridView1.DataSource = ds.Tables[0];
            count();

            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                btnDelete.Enabled = false;
            }

        }
        public void count()
        {
            lblCount.Text = "Numbers of \n Records: " + ds.Tables[0].Rows.Count.ToString();
        }
    }
    
}
