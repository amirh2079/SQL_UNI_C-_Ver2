using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlTest
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void First_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 900, 630);
            this.Region = new Region(path);
            this.Show();
        }
        Person secondPerson = new Person();
        Major secondMajor = new Major();
        Student secondStudent = new Student();
        Teacher secondTeacher = new Teacher();
        private void btnPerson_Click(object sender, EventArgs e)
        {
            secondPerson.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            secondStudent.Show();
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {
            secondMajor.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            secondTeacher.Show();
        }
    }
}
