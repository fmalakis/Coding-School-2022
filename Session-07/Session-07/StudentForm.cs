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

        public bool Edit { get; set; }

        public StudentForm()
        {
            InitializeComponent();
            this.Text = "Add new student";
            this.btnSave.Enabled = false;
        }

        public StudentForm(Student _CurrentStudent)
        {
            InitializeComponent();

            this.Text = "Edit student";

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

        private void confirmChanges()
        {
            if (this.txtboxName.Text != string.Empty && this.txtboxAge.Text != string.Empty && this.txtboxID.Text != string.Empty)
            {
                this.DialogResult = DialogResult.OK;

                if (CurrentStudent == null)
                {
                    this.newStudent = new Student(this.txtboxName.Text, Convert.ToInt32(this.txtboxAge.Text), Convert.ToInt32(this.txtboxID.Text));
                    Edit = false;
                } 
                else
                {
                    CurrentStudent.Name = this.txtboxName.Text;
                    CurrentStudent.Age = Convert.ToInt32(this.txtboxAge.Text);
                    CurrentStudent.RegistrationNumber = Convert.ToInt32(this.txtboxID.Text);
                    Edit = true;
                }

                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {
            if (txtboxName.Text == string.Empty || txtboxName == null)
            {
                btnSave.Enabled = false;
                return;
            }

            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
