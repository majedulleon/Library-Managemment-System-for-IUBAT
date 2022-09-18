using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LMS_gen3
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommandBuilder builder;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "insert into Books (Title,isbn,author,year,category,series,edition,price,rack,self) values ('"+this.textBox1.Text+ "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.comboBox1.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "')";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query,conDataBase);
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
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "update Books set title='" + this.textBox1.Text + "',isbn='" + this.textBox2.Text + "',author='" + this.textBox3.Text + "',year='" + this.textBox4.Text + "',category='" + this.comboBox1.Text + "',series='" + this.textBox6.Text + "',edition='" + this.textBox7.Text + "',price='" + this.textBox8.Text + "',rack='" + this.textBox9.Text + "',self='" + this.textBox10.Text + "' where isbn='" + this.textBox2.Text + "' ";
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
            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "delete from Books where isbn='" + this.textBox2.Text + "' ";
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

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "select * from Books"; //changing  * to different column name will show that values only
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            string sql = "select * from Books";
            ds = new DataSet();
            sda = new SqlDataAdapter(sql, con);
            sda.Fill(ds);
            builder = new SqlCommandBuilder(sda);
            dataGridView1.DataSource = ds.Tables[0];
            count();


            if(((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                btnDelete.Enabled = false;
            }


        }
        public void count()
        {
            lblshow.Text = "Numbers of Books: " + ds.Tables[0].Rows.Count.ToString();
        }
    }
    }

