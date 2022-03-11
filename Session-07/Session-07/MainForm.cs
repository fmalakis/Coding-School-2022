using Newtonsoft.Json;
using System;
using System.IO;
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
    public partial class MainForm : Form
    {

        private StudentManager studentManager;

        private StudentManager studentManagerClone;

        private Student currentStudent;
        private int currentIndex;

        public MainForm()
        {
            InitializeComponent();
            studentManager = new StudentManager();

            if (lstboxStudents.SelectedIndex == -1)
            {
                this.btnEdit.Enabled =  false;
                this.btnRemove.Enabled = false;
            }

            if (File.Exists("students.json"))
            {
                string jsonString = File.ReadAllText("students.json");
                studentManager.Students = JsonConvert.DeserializeObject<List<Student>>(jsonString);
            }

            studentManagerClone = studentManager.Clone();


            //populateTable();
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
                this.lstboxStudents.Items.Add($"Name: {item.Name} | Age: {item.Age} | Registration Number: {item.RegistrationNumber}");
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

        private void saveDataToDisk()
        {



            string studentJson = JsonConvert.SerializeObject(studentManager.Students);
            File.WriteAllText("students.json", studentJson);
        }

        private void savePrompt()
        {
            if (MessageBox.Show("Do you want to save your changes?", "Save and exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveDataToDisk();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            savePrompt();
        }

        private void lstboxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxStudents.SelectedIndex == -1)
            {
                this.btnRemove.Enabled = false;
                this.btnEdit.Enabled = false;
            }
            else
            {
                this.btnRemove.Enabled = true;
                this.btnEdit.Enabled = true;
            }
        }
    }
}
