using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityLogic;

namespace Session_07
{
    public partial class CourseForm : Form
    {

        public Course currentCourse { get; set; }

        public CourseForm()
        {
            InitializeComponent();

            this.btnSave.Enabled = false;

            this.Text = "Add new course";

        }

        public CourseForm(Course _course)
        {
            InitializeComponent();

            this.Text = "Edit course";

            currentCourse = _course;
            setUpTextFields();
        }

        private void setUpTextFields()
        {
            this.txtboxCode.Text = currentCourse.Code;
            this.txtboxSubject.Text = currentCourse.Subject;

            this.btnSave.Enabled = true;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void txtboxCode_TextChanged(object sender, EventArgs e)
        {
            if (txtboxCode.Text != string.Empty)
            {
                this.btnSave.Enabled = true;
                return;
            }
                

            this.btnSave.Enabled = false;
        }

        private void txtboxSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtboxSubject.Text != string.Empty)
            {
                this.btnSave.Enabled = true;
                return;
            }


            this.btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (currentCourse == null)
            {
                currentCourse = new Course(txtboxCode.Text, txtboxSubject.Text);
                
            } else
            {
                currentCourse.Code = txtboxCode.Text;
                currentCourse.Subject = txtboxSubject.Text;
            }
            

            this.DialogResult = DialogResult.OK;

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
