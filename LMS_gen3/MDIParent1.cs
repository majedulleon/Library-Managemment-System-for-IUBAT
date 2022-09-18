using System;
using System.Windows.Forms;

namespace LMS_gen3
{
    public partial class MDIParent1 : Form
    {

        public MDIParent1(string role)
        {
            InitializeComponent();
            label1.Text = role;
        }

        private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            book.MdiParent = this;
            book.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWatch.Text = "Current Date Time is: " + DateTime.Now.ToString();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void studentMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudents students = new frmStudents();
            students.MdiParent = this;
            students.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void studentProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentlist stulist = new frmStudentlist();
            stulist.MdiParent = this;
            stulist.Show();
        }

        private void manageJournalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJournals journals = new frmJournals();
            journals.MdiParent = this;
            journals.Show();
        }

        private void facultyMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty faculty = new frmFaculty();
            faculty.MdiParent = this;
            faculty.Show();
        }

        private void facultyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultylist facultylist = new frmFacultylist();
            facultylist.MdiParent = this;
            facultylist.Show();
        }

        private void issueForStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstuborrowlist stuborrowlist = new frmstuborrowlist();
            stuborrowlist.MdiParent = this;
            stuborrowlist.Show();
        }

        private void issueForFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultyBorrowList fblist = new frmFacultyBorrowList();
            fblist.MdiParent = this;
            fblist.Show();
        }

        private void sendEmailToStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuEmail semail = new frmStuEmail();
            semail.MdiParent = this;
            semail.Show();
        }

        private void sendEmailToFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacEmail femail = new frmFacEmail();
            femail.MdiParent = this;
            femail.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMe me = new frmMe();
            me.MdiParent = this;
            me.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
