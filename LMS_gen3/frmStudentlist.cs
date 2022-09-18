using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS_gen3
{
    public partial class frmStudentlist : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
        SqlDataAdapter sda;
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder builder;

        public frmStudentlist()
        {
            InitializeComponent();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "select * from Students"; //changing  * to different column name will show that values only
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
                dgvDataSource.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select * from Students where Stuid like '%" + textBox1.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvDataSource.DataSource = dt;
            
        }

        private void frmStudentlist_Load(object sender, EventArgs e)
        {
            string sql = "select * from Students";
            ds = new DataSet();
            sda = new SqlDataAdapter(sql, con);
            sda.Fill(ds);
            builder = new SqlCommandBuilder(sda);
            dgvDataSource.DataSource = ds.Tables[0];
            count();
        }
        public void count()
        {
            lblCount.Text = "Numbers of Records: " + ds.Tables[0].Rows.Count.ToString();
        }
    }

    }
    

