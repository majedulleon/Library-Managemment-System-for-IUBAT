using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LMS_gen3
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog()==DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                txtPath.Text = picPath;
                pictureBox1.ImageLocation = picPath;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] imgBt = null;
            FileStream filestream = new FileStream(this.txtPath.Text,FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(filestream);
            imgBt = br.ReadBytes((int)filestream.Length);


            string conString = LMS_gen3.Properties.Settings.Default.Connection;
            string query = "insert into Students (Name,Stuid,Department,Gender,DOB,Mobile,Email,Image) values ('" + this.textBox2.Text + "','" + this.textBox1.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.dateTimePicker1.Text + "','" + this.textBox5.Text + "','" + this.textBox4.Text + "',@IMG)";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            byte[] imgBt = null;
            FileStream filestream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(filestream);
            imgBt = br.ReadBytes((int)filestream.Length);
                        
            string conString = Properties.Settings.Default.Connection;
            string query = "update Students set Name='" + this.textBox2.Text + "',Stuid='" + this.textBox1.Text + "',Department='" + this.textBox1.Text + "',Gender='" + this.comboBox2.Text + "',DOB='" + this.dateTimePicker1.Text + "',Mobile='" + this.textBox5.Text + "',Email='" + this.textBox4.Text + "',Image= @IMG where Stuid='" + this.textBox1.Text + "' ";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            byte[] imgBt = null;
            FileStream filestream = new FileStream(this.txtPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(filestream);
            imgBt = br.ReadBytes((int)filestream.Length);


            string conString = Properties.Settings.Default.Connection;
            string query = "delete from Students where Stuid='" + this.textBox1.Text + "' ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                btnDelete.Enabled = false;
            }
        }
    }
    
}
