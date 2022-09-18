using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using HPTCNotification;

namespace LMS_gen3
{
    public partial class frmFacultyBorrowStatus : Form
    {
        public frmFacultyBorrowStatus()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
        SqlDataAdapter sda;
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder builder;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            sda = new SqlDataAdapter("select * from FacBorrow", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select * from FacBorrow where MemberId like '%" + textBox1.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "select DueDate from FacBorrow";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query,conDataBase);
            SqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    DateTime sDueDate = (DateTime)myReader["DueDate"];

                    foreach(DataGridViewColumn dc in dataGridView1.Columns)
                    {
                        if(sDueDate<DateTime.Now)
                        {
                            Notification nf = new Notification("Submission Date Expired \n --Check Borrowlist--", "Close", Notification.NotificationIcon.Update, false, 5);
                            nf.ShowOnScreen();
                        }
                    }
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
           
        }

        private void frmFacultyBorrowStatus_Load(object sender, EventArgs e)
        {
            string sql = "select * from FacBorrow";
            ds = new DataSet();
            sda = new SqlDataAdapter(sql, con);
            sda.Fill(ds);
            builder = new SqlCommandBuilder(sda);
            dataGridView1.DataSource = ds.Tables[0];
            count();
        }
        public void count()
        {
            lblCount.Text = "Numbers of Records: " + ds.Tables[0].Rows.Count.ToString();
        }
    }
    }

