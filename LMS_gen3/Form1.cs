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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            SqlDataAdapter sda = new SqlDataAdapter("select Role from login where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "' ", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MDIParent1 mdip1 = new MDIParent1(dt.Rows[0][0].ToString());
                mdip1.Show();
            }
            else
            {
                MessageBox.Show("Error ! Please Check Username and Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
