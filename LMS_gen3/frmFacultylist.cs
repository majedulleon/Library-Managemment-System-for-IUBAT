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
using HPTCNotification;

namespace LMS_gen3
{
    public partial class frmFacultylist : Form
    {
        public frmFacultylist()
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
            sda = new SqlDataAdapter("select * from Faculty", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvDataSource.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmFacultylist_Load(object sender, EventArgs e)
        {
            string sql = "select * from Faculty";
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
