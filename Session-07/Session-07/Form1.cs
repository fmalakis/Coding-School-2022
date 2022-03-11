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
    public partial class Form1 : Form
    {

        private StudentManager studentManager;

        private Student currentStudent;
        private int currentIndex;

        public Form1()
        {
            InitializeComponent();
            studentManager = new StudentManager();
            populateTable();
            updateListBox();
        }

        #region UI Control

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void lstboxStudents_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.currentStudent = this.studentManager.Students[lstboxStudents.SelectedIndex];
        //    currentIndex = lstboxStudents.SelectedIndex;
        //}

        #endregion

        private void populateTable()
        {
            this.studentManager.Add(new Student("Fotis", 21, 1));
            this.studentManager.Add(new Student("Giannis", 41, 2));
            this.studentManager.Add(new Student("Lmao", 23, 3));

        }

        private void updateListBox()
        {
            foreach (Student item in studentManager.Students)
            {
                this.lstboxStudents.Items.Add($"Name: {item.Name} | Age: {item.Age} | ID: {item.RegistrationNumber}");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            updateCurrentStudent();

            this.studentManager.Remove(currentStudent);
            removeEntry(currentIndex);
            
            
            //updateListBox();
        }

        private void updateCurrentStudent()
        {
            currentIndex = lstboxStudents.SelectedIndex;
            currentStudent = studentManager.Students[currentIndex];
        }

        private void removeEntry(int index)
        {
            this.lstboxStudents.Items.RemoveAt(index);
        }

        private void addEntry(Student student)
        {
            studentManager.Add(student);
            this.lstboxStudents.Items.Add($"Name: {student.Name} | Age: {student.Age} | ID: {student.RegistrationNumber}");
        }

        private void updateEntry()
        {
            studentManager.Update(currentStudent);
            lstboxStudents.Items.Remove(currentIndex);
            lstboxStudents.Items[currentIndex] = $"Name: {currentStudent.Name} | Age: {currentStudent.Age} | ID: {currentStudent.RegistrationNumber}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();

            if (studentForm.ShowDialog() == DialogResult.OK)
            {
                addEntry(studentForm.newStudent);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            updateCurrentStudent();

            StudentForm studentForm = new StudentForm(currentStudent);

            if (studentForm.ShowDialog() == DialogResult.OK)
            {
                updateEntry();

            }
        }
    }
}
