using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cSharpSimpleCalculator
{
   //By J.A. Brown - basic C# coding teaching example
   // Used to illustrate basic variable declaration and initialization,
   // control flow logic, and XAML UI design
    public partial class MainWindow : Window
    {

        //Initialize variables num1 (first value), num2 (second value), and oper (string indicating the mathematical operation to be performed)
        long num1 = 0;
        long num2 = 0;
        string oper = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 1;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "+")
            {
                calculatorValue.Text = (num1 + num2).ToString();
                num1 += num2;
                num2 = 0;
            }
            else if (oper == "-")
            {
                calculatorValue.Text = (num1 - num2).ToString();
                num1 -= num2;
                num2 = 0;
            }
            else if (oper == "*")
            {
                calculatorValue.Text = (num1 * num2).ToString();
                num1 *= num2;
                num2 = 0;
            }
            else if (oper == "/")
            {
                try
                {
                    calculatorValue.Text = (num1 / num2).ToString();
                    num1 /= num2;
                    num2 = 0;
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Error: Division by 0 not Allowed");
                }
            }
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 2;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 3;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 6;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 5;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 4;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 7;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 8;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10) + 9;
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                calculatorValue.Text = num2.ToString();
            }
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                num1 = (num1 * 10);
                calculatorValue.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                calculatorValue.Text = num2.ToString();
            }
        }

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            oper = "+";
            calculatorValue.Clear();

            calculatorValue.Text = "0";
        }

        private void subtractionButton_Click(object sender, RoutedEventArgs e)
        {
            oper = "-";
            calculatorValue.Text = "0";
        }

        private void multiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            oper = "*";
            calculatorValue.Text = "0";
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            oper = "/";
            calculatorValue.Text = "0";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            oper = "";
            calculatorValue.Clear();
        }
    }
}
