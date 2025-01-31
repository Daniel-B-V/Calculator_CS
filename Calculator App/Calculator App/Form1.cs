namespace Calculator_App
{
    public partial class Form1 : Form
    {

        private decimal firstValue = 0.0m;
        private decimal secondValue = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        private bool isResultDisplayed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox.SelectionStart = txtBox.Text.Length;
            txtBox.SelectionLength = 0;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "0";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "0";
                MoveTextIfFull();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "1";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "1";
                MoveTextIfFull();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "2";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "2";
                MoveTextIfFull();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "3";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "3";
                MoveTextIfFull();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "4";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "4";
                MoveTextIfFull();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "5";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "5";
                MoveTextIfFull();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "6";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "6";
                MoveTextIfFull();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "7";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "7";
                MoveTextIfFull();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "8";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "8";
                MoveTextIfFull();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "9";
                MoveTextIfFull();
            }
            else
            {
                txtBox.Text += "9";
                MoveTextIfFull();
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!txtBox.Text.Contains("."))
            {
                txtBox.Text += ".";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "0" && !txtBox.Text.EndsWith("+") && !txtBox.Text.EndsWith("-") && !txtBox.Text.EndsWith("*") && !txtBox.Text.EndsWith("/"))
            {
                txtBox.Text += "+";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" || txtBox.Text == "")
            {
                txtBox.Text = "-";
            }
            else if (!txtBox.Text.EndsWith("+") && !txtBox.Text.EndsWith("-") && !txtBox.Text.EndsWith("*") && !txtBox.Text.EndsWith("/"))
            {
                txtBox.Text += "-";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "0" && !txtBox.Text.EndsWith("+") && !txtBox.Text.EndsWith("-") && !txtBox.Text.EndsWith("*") && !txtBox.Text.EndsWith("/"))
            {
                txtBox.Text += "*";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "0" && !txtBox.Text.EndsWith("+") && !txtBox.Text.EndsWith("-") && !txtBox.Text.EndsWith("*") && !txtBox.Text.EndsWith("/"))
            {
                txtBox.Text += "/";
            }
        }


        private void MoveTextIfFull()
        {
            const int maxLength = 15;
            if (txtBox.Text.Length > maxLength)
            {
                txtBox.Text = txtBox.Text.Substring(1);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                var expression = txtBox.Text;
                if (expression.EndsWith("+") || expression.EndsWith("-") || expression.EndsWith("*") || expression.EndsWith("/"))
                {
                    MessageBox.Show("Invalid expression. Cannot end with an operator.");
                    return;
                }

                var result = new System.Data.DataTable().Compute(expression, null);
                txtBox.Text = result.ToString();
                isResultDisplayed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in expression: " + ex.Message);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (isResultDisplayed)
            {
                txtBox.Text = "0";
                isResultDisplayed = false;
            }
            else if (txtBox.Text.Length > 1)
            {
                txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
            }
            else
            {
                txtBox.Text = "0";
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
