using static Calculator.Operations;


namespace Session_06
{
    public partial class CalculatorForm : Form
    {

        private string firstNum, secondNum, result;
        private bool dotPresent;

        public CalculatorForm()
        {
            InitializeComponent();
            firstNum = secondNum = result = string.Empty;
            dotPresent = false;
        }

        private void clearResultTextBox()
        {
            this.resultTextBox.Clear();
        }

        private void clearTempTextBox()
        {
            this.tempTextBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "7";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.resultTextBox.Text != String.Empty)
                this.resultTextBox.Text += "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "4";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "5";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.resultTextBox.Text += "8";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstNum = this.resultTextBox.Text;

            this.tempTextBox.Text += firstNum + " + ";

            this.clearResultTextBox();

            dotPresent = false;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!dotPresent)
            {
                this.resultTextBox.Text += (this.resultTextBox.Text == string.Empty? "0" : "") + ",";
                dotPresent = true;
            }
                
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.clearResultTextBox();
            this.clearTempTextBox();

            firstNum = secondNum = result = string.Empty;

            dotPresent= false;

        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {

            secondNum = this.resultTextBox.Text;

            if (firstNum == String.Empty)
                return;

            if (Int32.TryParse(firstNum, out int result1) && Int32.TryParse(secondNum, out int result2)) 
                result = Convert.ToString(Calculator.Operations.Add(result1, result2));
            else
                result = Convert.ToString(Calculator.Operations.Add(Convert.ToDouble(firstNum), Convert.ToDouble(secondNum)));


            this.tempTextBox.Text += secondNum + " = ";

            this.resultTextBox.Text = result;
            

        }
    }
}