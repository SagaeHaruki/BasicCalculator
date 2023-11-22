using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            first_box.Text = "0";
            second_box.Text = "0";
            reslt.Text = "Total: " + Environment.NewLine + "000000";

            string[] operators = new string[]
            {
                "+","-","/","*"

            };
            for (int i = 0; i < 4; i++)
            {
                operatorCMB.Items.Add(operators[i].ToString());
            }

            operatorCMB.SelectedIndex = 0;
        }

        private void compute_btn_Click(object sender, EventArgs e)
        {
            float number1, number2;
            if (!float.TryParse(first_box.Text, out number1))
            {
                MessageBox.Show("First Box is Invalid");
                return;
            }
            if (!float.TryParse(second_box.Text, out number2))
            {
                MessageBox.Show("Second Box is Invalid");
                return;
            }

            string operator_used = operatorCMB.Text;
            
            float num1 = Convert.ToSingle(first_box.Text);
            float num2 = Convert.ToSingle(second_box.Text);

            switch (operator_used)
            {
                case "*":
                    CalculatorPrivateAssembls.BasicCompute prod = new CalculatorPrivateAssembls.BasicCompute();
                    reslt.Text = "Total: " + Environment.NewLine + prod.Multiplication(num1, num2);
                    break;
                case "+":
                    CalculatorPrivateAssembls.BasicCompute sum = new CalculatorPrivateAssembls.BasicCompute();
                    reslt.Text = "Total: " + Environment.NewLine + sum.Addition(num1, num2);
                    break;
                case "-":
                    CalculatorPrivateAssembls.BasicCompute diff = new CalculatorPrivateAssembls.BasicCompute();
                    reslt.Text = "Total: " + Environment.NewLine + diff.Subtraction(num1, num2);
                    break;
                case "/":
                    CalculatorPrivateAssembls.BasicCompute quo = new CalculatorPrivateAssembls.BasicCompute();
                    reslt.Text = "Total: " + Environment.NewLine + quo.Division(num1, num2);
                    break;
                default:
                    break;
            }
        }

        private void operatorCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operator_used = operatorCMB.Text;

            float num1 = Convert.ToSingle(first_box.Text);
            float num2 = Convert.ToSingle(second_box.Text);

            switch (operator_used)
            {
                case "*":
                    CalculatorPrivateAssembls.BasicCompute prod = new CalculatorPrivateAssembls.BasicCompute();
                    reslt.Text = "Total: " + Environment.NewLine + prod.Multiplication(num1, num2);
                    break;
                case "+":
                    CalculatorPrivateAssembls.BasicCompute sum = new CalculatorPrivateAssembls.BasicCompute();
                    reslt.Text = "Total: " + Environment.NewLine + sum.Addition(num1, num2);
                    break;
                case "-":
                    CalculatorPrivateAssembls.BasicCompute diff = new CalculatorPrivateAssembls.BasicCompute();
                    reslt.Text = "Total: " + Environment.NewLine + diff.Subtraction(num1, num2);
                    break;
                case "/":
                    CalculatorPrivateAssembls.BasicCompute quo = new CalculatorPrivateAssembls.BasicCompute();
                    reslt.Text = "Total: " + Environment.NewLine + quo.Division(num1, num2);
                    break;
                default:
                    break;
            }
        }
    }
}
