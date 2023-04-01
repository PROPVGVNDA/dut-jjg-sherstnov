using System.DirectoryServices;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorPastGen
{
    public partial class Form1 : Form
    {
        private string buffer = "";
        private char operation = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void FlushInput()
        {
            input.Text = "";
            buffer = "";
            operation = ' ';
        }

        private bool CheckIfContainsDot()
        {
            return input.Text.Contains('.');
        }

        private static Double Calculate(char op, Double a, Double b)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '/':
                    if (b == 0)
                        throw new DivideByZeroException();
                    return a / b;
                case '*':
                    return a * b;
                default:
                    throw new ArgumentNullException(nameof(op), "Operation cannot be processed");
            }
        }
        private void ButtonClickHandler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var isNumeric = int.TryParse(btn.Text, out int n);
            if (isNumeric)
            {
                input.Text += btn.Text;
            }

            switch (btn.Text)
            {
                case "+/-":
                    if (string.IsNullOrEmpty(input.Text)) { break; }
                    input.Text = input.Text[0] == '-' ? input.Text[1..] : input.Text.Insert(0, "-");
                    break;
                case "C":
                    FlushInput();
                    break;
                case ".":
                    if (CheckIfContainsDot()) { break; }
                    input.Text += ".";
                    break;
                case "=":
                    if (string.IsNullOrEmpty(buffer) || operation == ' ') { break; }
                    else
                    {
                        try
                        {
                            input.Text = Calculate(operation,
                                Double.Parse(buffer, CultureInfo.InvariantCulture),
                                Double.Parse(input.Text, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
                        }
                        catch (DivideByZeroException)
                        {
                            FlushInput();
                            MessageBox.Show("Can't divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        buffer = "";
                    }
                    break;
                case "+":
                    operation = '+';
                    if (!(string.IsNullOrEmpty(buffer))) { break; }
                    buffer = input.Text;
                    input.Text = "";
                    break;
                case "-":
                    if (string.IsNullOrEmpty(input.Text))
                    {
                        input.Text = "-";
                        break;
                    }
                    else
                    {
                        operation = '-';
                        if (!(string.IsNullOrEmpty(buffer))) { break; }
                        buffer = input.Text;
                        input.Text = "";
                        break;
                    }

                case "*":
                    operation = '*';
                    if (!(string.IsNullOrEmpty(buffer))) { break; }
                    buffer = input.Text;
                    input.Text = "";
                    break;
                case "/":
                    operation = '/';
                    if (!(string.IsNullOrEmpty(buffer))) { break; }
                    buffer = input.Text;
                    input.Text = "";
                    break;
            }
        }

    }
}