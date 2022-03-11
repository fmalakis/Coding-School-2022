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

        private ProfessorManager professorManager;
        private Professor currentProfessor;

        private CourseManager courseManager;

        private int currentIndex;
        private int currentProfIndex;

        public MainForm()
        {
            InitializeComponent();
            studentManager = new StudentManager();
            professorManager = new ProfessorManager();
            courseManager = new CourseManager();

            if (lstboxStudents.SelectedIndex == -1)
            {
                this.btnEdit.Enabled =  false;
                this.btnRemove.Enabled = false;
            }

            if (DataLoader.FetchStudents(out List<Student> students))
            {
                studentManager.Students = students;
            }

            if (DataLoader.FetchProfessors(out List<Professor> professors))
            {
                professorManager.Professors = professors;
            }

            if (DataLoader.FetchCourses(out List<Course> courses))
            {
                courseManager.Courses = courses;
            }

            studentManagerClone = studentManager.Clone();


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

        private void checkAndUpdateBtns()
        {
            if (lstboxStudents.SelectedIndex == -1)
            {
                this.btnEdit.Enabled = false;
                this.btnRemove.Enabled = false;
            }
            else
            {
                this.btnEdit.Enabled = true;
                this.btnRemove.Enabled = true;
            }

            if (lstboxProf.SelectedIndex == -1)
            {
                this.btnEditProf.Enabled = false;
                this.btnRemoveProf.Enabled = false;
            }
            else
            {
                this.btnEditProf.Enabled = true;
                this.btnRemoveProf.Enabled = true;
            }
        }

        private void updateListBox()
        {
            foreach (Student item in studentManager.Students)
            {
                this.lstboxStudents.Items.Add($"Name: {item.Name} | Age: {item.Age} | Registration Number: {item.RegistrationNumber}");
            }

            foreach (Professor professor in professorManager.Professors)
            {
                lstboxProf.Items.Add($"Name: {professor.Name} | Rank: {professor.Rank} | Age: {professor.Age} ");
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
            DataLoader.SaveStudents(studentManager.Students);
            DataLoader.SaveProfessors(professorManager.Professors);
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
            checkAndUpdateBtns();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void lstboxProf_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkAndUpdateBtns();

            //currentProfIndex = lstboxProf.SelectedIndex;
            //currentProfessor = professorManager.Professors[currentProfIndex];
        }

        private void btnAddProf_Click(object sender, EventArgs e)
        {
            ProfessorForm professorForm = new ProfessorForm();

            if (professorForm.ShowDialog() == DialogResult.OK)
            {

                currentProfessor = professorForm.CurrentProfessor;

                professorManager.Add(currentProfessor);
                lstboxProf.Items.Add($"Name: {currentProfessor.Name} | Rank: {currentProfessor.Rank} | Age: {currentProfessor.Age} ");
            }
        }

        private void btnEditProf_Click(object sender, EventArgs e)
        {
            ProfessorForm professorForm = new ProfessorForm(currentProfessor);

            if (professorForm.ShowDialog() == DialogResult.OK)
            {
                currentProfessor = professorForm.CurrentProfessor;

                professorManager.Update(currentProfessor);

                lstboxProf.Items[currentIndex] = $"Name: {currentProfessor.Name} | Rank: {currentProfessor.Rank} | Age: {currentProfessor.Age} ";

            }
        }

        private void btnRemoveProf_Click(object sender, EventArgs e)
        {
            currentProfIndex = lstboxProf.SelectedIndex;
            currentProfessor = professorManager.Professors[currentProfIndex];
            professorManager.Remove(currentProfessor);
            lstboxProf.Items.RemoveAt(currentProfIndex);
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
