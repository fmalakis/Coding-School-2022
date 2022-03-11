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
    public partial class StudentForm : Form
    {

        public Student newStudent { get; set; }
        public Student CurrentStudent { get; }
        public List<Course> currentStudentCourses = new List<Course>();

        private Student studentClone;

        private bool edit = false;

        public StudentForm()
        {
            InitializeComponent();
            this.Text = "Add new student";
            this.btnSave.Enabled = false;

            this.edit = true;



        }

        public StudentForm(Student _CurrentStudent)
        {
            InitializeComponent();

            this.Text = "Edit student";
            this.btnSave.Enabled = false;

            studentClone = _CurrentStudent.Clone();

            CurrentStudent = _CurrentStudent;

            this.txtboxName.Text = CurrentStudent.Name;
            this.txtboxAge.Text = CurrentStudent.Age.ToString();
            this.txtboxID.Text = CurrentStudent.RegistrationNumber.ToString();

        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            confirmChanges();
        }

        private void checkAndDisableButtons()
        {
            if (lstboxCourses.SelectedIndex == -1)
            {
                this.btnRemove.Enabled = false;
                this.btnEditCourse.Enabled = false;
            }
            else
            {
                this.btnRemove.Enabled = true;
                this.btnEditCourse.Enabled = true;
            }
        }

        private void confirmChanges()
        {
            if (this.txtboxName.Text != string.Empty && this.txtboxAge.Text != string.Empty && this.txtboxID.Text != string.Empty)
            {
                this.DialogResult = DialogResult.OK;

                if (CurrentStudent == null)
                {
                    this.newStudent = new Student(this.txtboxName.Text, Convert.ToInt32(this.txtboxAge.Text), Convert.ToInt32(this.txtboxID.Text));
                    newStudent.courses = this.currentStudentCourses;
                    edit = false;
                } 
                else
                {
                    CurrentStudent.Name = this.txtboxName.Text;
                    CurrentStudent.Age = Convert.ToInt32(this.txtboxAge.Text);
                    CurrentStudent.RegistrationNumber = Convert.ToInt32(this.txtboxID.Text);
                    CurrentStudent.courses = this.currentStudentCourses;
                    edit = true;
                }

                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

            checkAndDisableButtons();

            if (CurrentStudent == null)
                return;

            foreach (Course course in CurrentStudent.courses)       
            {
                this.lstboxCourses.Items.Add($"Code: {course.Code} | Subject: {course.Subject}");
            }
        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

            if (txtboxName.Text != string.Empty && txtboxAge.Text != string.Empty && txtboxID.Text != string.Empty)
            {
                btnSave.Enabled = true;
                return;
            }

            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            revertChoices();
        }

        private void revertChoices()
        {
            this.txtboxName.Text = studentClone.Name;
        }

        private void txtboxID_TextChanged(object sender, EventArgs e)
        {
            if (txtboxID.Text == string.Empty || txtboxID == null)
            {
                btnSave.Enabled = false;
                return;
            }

            btnSave.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();

            if (courseForm.ShowDialog() == DialogResult.OK)
            {
                addEntry(new Course(courseForm.currentCourse.Code, courseForm.currentCourse.Subject));
            }
        }

        private void lstboxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAndDisableButtons();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm(CurrentStudent.courses[lstboxCourses.SelectedIndex]);

            if (courseForm.ShowDialog() == DialogResult.OK)
            {
                CurrentStudent.courses.Remove(CurrentStudent.courses[lstboxCourses.SelectedIndex]);
                updateCourseTable(lstboxCourses.SelectedIndex, courseForm.currentCourse);
            }
        }

        private void addEntry(Course course)
        {
            currentStudentCourses.Add(course);
            this.lstboxCourses.Items.Add($"Code: {course.Code} | Subject: {course.Subject}");
        }

        private void removeEntry()
        {
            CurrentStudent.courses.Remove(CurrentStudent.courses[lstboxCourses.SelectedIndex]);
            lstboxCourses.Items.RemoveAt(lstboxCourses.SelectedIndex);
        }

        private void updateCourseTable(int index, Course newCourse)
        {
            CurrentStudent.courses.Add(newCourse);
            lstboxCourses.Items.RemoveAt(index);
            this.lstboxCourses.Items.Add($"Code: {newCourse.Code} | Subject: {newCourse.Subject}");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeEntry();
        }
    }
}
