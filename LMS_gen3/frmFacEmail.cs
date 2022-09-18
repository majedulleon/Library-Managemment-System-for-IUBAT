using System;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace LMS_gen3
{
    public partial class frmFacEmail : Form
    {
        public frmFacEmail()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        SqlConnection con = new SqlConnection(LMS_gen3.Properties.Settings.Default.Connection);
        SqlDataAdapter sda;
        DataTable dt;

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAttachment.Text = openFileDialog1.FileName.ToString();

            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient Client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress(txtFrom.Text);
                Message.To.Add(txtTo.Text);
                Message.Body = txtBody.Text;
                Message.Subject = txtSubject.Text;
                Client.UseDefaultCredentials = false;
                Client.EnableSsl = true;

                if (txtAttachment.Text != "")
                {
                    Message.Attachments.Add(new Attachment(txtAttachment.Text));
                }
                Client.Credentials = new System.Net.NetworkCredential(txtFrom.Text, txtPassword.Text);
                Client.Send(Message);
                Message = null;

                MessageBox.Show("Email Sent");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CSE")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Name, Email from Faculty where Department like '%" + comboBox1.Text + "%' and MemberId like '%" + textBox7.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "EEE")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Name, Email from Faculty where Department like '%" + comboBox1.Text + "%' and MemberId like '%" + textBox7.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "ME")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Name, Email from Facuty where Department like '%" + comboBox1.Text + "%' and MemberId like '%" + textBox7.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "CE")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Name, Email from Faculty where Department like '%" + comboBox1.Text + "%' and MemberId like '%" + textBox7.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "BBA")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Name, Email from Faculty where Department like '%" + comboBox1.Text + "%' and MemberId like '%" + textBox7.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "BATHM")
            {
                string conString = Properties.Settings.Default.Connection;
                sda = new SqlDataAdapter("select Name, Email from Faculty where Department like '%" + comboBox1.Text + "%' and MemberId like '%" + textBox7.Text + "%' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void frmFacEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
