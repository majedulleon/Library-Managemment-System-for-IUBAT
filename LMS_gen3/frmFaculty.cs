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
using System.IO;

namespace LMS_gen3
{
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] imgBt = null;
            FileStream filestream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(filestream);
            imgBt = br.ReadBytes((int)filestream.Length);

            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "insert into Faculty (Name,Department,MemberId,Mobile,Email,Image) values ('" + this.textBox1.Text + "','" + this.comboBox1.Text + "','"+this.textBox4.Text+"','" + this.textBox2.Text + "','" + this.textBox3.Text + "',@IMG)";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                cmdDataBase.Parameters.Add(new SqlParameter("@IMG", imgBt));
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

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imgBt = null;
            FileStream filestream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(filestream);
            imgBt = br.ReadBytes((int)filestream.Length);

            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "update Faculty set Name='" + this.textBox1.Text + "',Department='" + this.comboBox1.Text + "',MemberId='"+this.textBox4.Text+"',Mobile='" + this.textBox2.Text + "',Email='" + this.textBox3.Text + "',Image=@IMG where Name='" + this.textBox1.Text + "' ";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                cmdDataBase.Parameters.Add(new SqlParameter("@IMG", imgBt));
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                txtPath.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] imgBt = null;
            FileStream filestream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(filestream);
            imgBt = br.ReadBytes((int)filestream.Length);

            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "delete from Faculty where Name='" + this.textBox1.Text + "' ";
            SqlConnection conDataBase = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            SqlDataReader myReader;

            try
            {
                conDataBase.Open();
                cmdDataBase.Parameters.Add(new SqlParameter("@IMG", imgBt));
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

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                button4.Enabled = false;
            }
        }
    }
}
