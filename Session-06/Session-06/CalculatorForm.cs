using Calculator;


namespace Session_06
{
    public partial class CalculatorForm : Form
    {

        private string firstNum, secondNum, result;
        private bool dotPresent;
        private ArithmeticalOperation arithmeticalOperation = ArithmeticalOperation.NOOP;
        private ArithmeticalOperationResolver resolver;
        private ArithmeticOperationLogger logger;

        public CalculatorForm()
        {
            InitializeComponent();
            firstNum = secondNum = result = string.Empty;
            dotPresent = false;
            resolver = new ArithmeticalOperationResolver();
            logger = new ArithmeticOperationLogger();
        }

        private void clearResultTextBox()
        {
            this.resultTextBox.Clear();
        }

        private void clearTempTextBox()
        {
            this.tempTextBox.Clear();
        }

        private void lockCalculator()
        {
            this.button0.Enabled = false;
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
        }

        private void logAction()
        {
            logger.Write(new OperationMessage(arithmeticalOperation, tempTextBox.Text + result));

            refreshLog();
        }

        private void refreshLog()
        {
            this.logTextBox.Text = logger.FetchMessages();
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

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == string.Empty)
                return;

            firstNum = this.resultTextBox.Text;

            arithmeticalOperation = ArithmeticalOperation.Subtract;

            this.tempTextBox.Text = firstNum + " - ";

            this.clearResultTextBox();

            dotPresent = false;
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
            if (this.resultTextBox.Text != String.Empty || this.arithmeticalOperation == ArithmeticalOperation.Power)
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

            if (resultTextBox.Text == string.Empty)
                return;

            firstNum = this.resultTextBox.Text;

            arithmeticalOperation = ArithmeticalOperation.Add;

            this.tempTextBox.Text = firstNum + " + ";

            this.clearResultTextBox();

            dotPresent = false;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!dotPresent && !this.resultTextBox.Text.Contains(','))
            {
                this.resultTextBox.Text += (this.resultTextBox.Text == string.Empty? "0" : "") + ",";
                dotPresent = true;
            }
                
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {

            if (this.resultTextBox.Text == String.Empty)
                return;

            firstNum = this.resultTextBox.Text;

            arithmeticalOperation = ArithmeticalOperation.Root;

            result = resolver.Execute(arithmeticalOperation, firstNum);


            this.tempTextBox.Text = $"Sqrt({firstNum}) = ";

            this.resultTextBox.Text = result;

            logAction();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == string.Empty)
                return;

            firstNum = this.resultTextBox.Text;

            arithmeticalOperation = ArithmeticalOperation.Multiply;

            this.tempTextBox.Text = firstNum + " * ";

            this.clearResultTextBox();

            dotPresent = false;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == string.Empty)
                return;

            firstNum = this.resultTextBox.Text;

            arithmeticalOperation = ArithmeticalOperation.Divide;

            this.tempTextBox.Text = firstNum + " / ";

            this.clearResultTextBox();

            dotPresent = false;
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == string.Empty)
                return;

            firstNum = this.resultTextBox.Text;

            arithmeticalOperation = ArithmeticalOperation.Power;

            this.tempTextBox.Text = firstNum + " ^ ";

            this.clearResultTextBox();

            dotPresent = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.clearResultTextBox();
            this.clearTempTextBox();

            firstNum = secondNum = result = string.Empty;

            arithmeticalOperation = ArithmeticalOperation.NOOP;

            dotPresent= false;

        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {

            secondNum = this.resultTextBox.Text;

            if (firstNum == String.Empty)
                return;


            result = resolver.Execute(arithmeticalOperation, firstNum, secondNum);


            this.tempTextBox.Text += secondNum + " = ";

            this.resultTextBox.Text = result;

            logAction();


            arithmeticalOperation = ArithmeticalOperation.NOOP;

            //this.lockCalculator();
        }
    }
}