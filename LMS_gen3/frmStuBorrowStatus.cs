using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using HPTCNotification;

namespace LMS_gen3
{
    public partial class frmStuBorrowStatus : Form
    {
        public frmStuBorrowStatus()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
        SqlDataAdapter sda;
        DataTable dt;
        DataSet ds;
        SqlCommandBuilder builder;

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            sda = new SqlDataAdapter("select * from StuBorrow", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string conString = Properties.Settings.Default.Connection;
            sda = new SqlDataAdapter("select * from StuBorrow where Id like '%" + textBox1.Text + "%' ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.Connection;
            string query = "select Duedate from Facborrow";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    DateTime sDuedate = (DateTime)myReader["Duedate"];


                    foreach (DataGridViewColumn dc in dataGridView1.Columns)
                    {
                        if (sDuedate < DateTime.Now)
                        {
                            Notification nf = new Notification("Submission Date Expired \n --Please Check Data--", "Close", Notification.NotificationIcon.Update, false, 5);
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

        private void frmStuBorrowStatus_Load(object sender, EventArgs e)
        {
            string sql = "select * from StuBorrow";
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
