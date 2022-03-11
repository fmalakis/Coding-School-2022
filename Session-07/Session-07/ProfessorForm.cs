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
    public partial class ProfessorForm : Form
    {

        public Professor CurrentProfessor { get; set; }

        public ProfessorForm()
        {
            InitializeComponent();
        }

        public ProfessorForm(Professor professor)
        {
            InitializeComponent();

            CurrentProfessor = professor;

            setUpTextFields();

        }

        private void setUpTextFields()
        {
            this.txtboxName.Text = CurrentProfessor.Name;
            this.txtboxAge.Text = CurrentProfessor.Age.ToString();
            this.txtboxRank.Text = CurrentProfessor.Rank;
        }

        private void checkAndDisableButtons()
        {
            if (this.txtboxName.Text == String.Empty || this.txtboxAge.Text == String.Empty || this.txtboxRank.Text == string.Empty)
                this.btnSave.Enabled = false;
            else
                this.btnSave.Enabled = true;
        }

        private void ProfessorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CurrentProfessor == null)
                CurrentProfessor = new Professor(this.txtboxName.Text, Convert.ToInt32(this.txtboxAge.Text), this.txtboxRank.Text);
            else
            {
                CurrentProfessor.Name = txtboxName.Text;
                CurrentProfessor.Rank = txtboxRank.Text;
                CurrentProfessor.Age = Convert.ToInt32(txtboxAge.Text);
            }

            this.DialogResult = DialogResult.OK;

            this.Close();

        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {
            checkAndDisableButtons();
        }

        private void txtboxRank_TextChanged(object sender, EventArgs e)
        {
            checkAndDisableButtons();
        }

        private void txtboxAge_TextChanged(object sender, EventArgs e)
        {
            checkAndDisableButtons();
        }
    }
}
