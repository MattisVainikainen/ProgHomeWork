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

namespace Calculater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal number1 = 0;
        decimal number2 = 0;

        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void numAppend(int btnNum)
        {

            
            if (operation == "")
            {
                number1 = number1 * 10 + btnNum;
                txtDisplay.Text = number1.ToString();

            }
            else 
            {
                number2 = number2 * 10 + btnNum;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            numAppend(1);
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            numAppend(2);
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            numAppend(3);
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            numAppend(4);
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            numAppend(5);
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            numAppend(6);
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            numAppend(7);
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            numAppend(8);
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            numAppend(9);
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            numAppend(0);
        }

        private void btPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btComma_Click(object sender, RoutedEventArgs e)
        {

            txtDisplay.Text += ",";

        }

        private void btEqual_Click(object sender, RoutedEventArgs e)
        {
            
            switch (operation) 
            {
                case "+":
                    number2 = number1 + decimal.Parse(txtDisplay.Text);
                    labelCurrentOperation.Content = number1 + "+" + double.Parse(txtDisplay.Text);
                    txtDisplay.Text = number2.ToString();
                    number1 = 0;
                    break;

                case "-":
                    number2 = number1 - decimal.Parse(txtDisplay.Text);
                    txtDisplay.Text = number2.ToString();
                    number1 = 0;
                    //txtDisplay.Text = (number1 - number2).ToString();
                    //labelCurrentOperation.Content = $"{number1} - {number2} = {txtDisplay.Text}";
                    break;

                case "*":
                    number2 = number1 * decimal.Parse(txtDisplay.Text);
                    txtDisplay.Text = number2.ToString();
                    number1 = 0;
                    //txtDisplay.Text = (number1 * number2).ToString();
                    //labelCurrentOperation.Content = $"{number1} * {number2} = {txtDisplay.Text}";
                    break;

                case "/":
                    number2 = number1 / decimal.Parse(txtDisplay.Text);
                    txtDisplay.Text = number2.ToString();
                    number1 = 0;
                    //txtDisplay.Text = (number1 / number2).ToString();
                    //labelCurrentOperation.Content = $"{number1} / {number2} = {txtDisplay.Text}";

                    break;
            }

            number1 = 0;
            number2 = 0;
            operation = "";


        }

        private void btDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            labelCurrentOperation.Content = $"{number1} /";
            txtDisplay.Text = "";
        }

        private void btMulti_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            labelCurrentOperation.Content = $"{number1} *";
            txtDisplay.Text = "";
        }

        private void btMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            labelCurrentOperation.Content = $"{number1} -";
            txtDisplay.Text = "";
        }

        private void btPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            labelCurrentOperation.Content = $"{number1} +";
            txtDisplay.Text = "";
        }

        private void btBackSlash_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = DecimalToString(number1);
            }
            else
            {
                number2 = DecimalToString(number2);
            }


        }

        private decimal DecimalToString(decimal number)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            string numberHolder = number.ToString();
            numberHolder = numberHolder.Substring(0, numberHolder.Length - 1);
            number = decimal.Parse(numberHolder);
            return number;
        }

        private void btC_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This Calculator was made By Mattis Vainikainen \nThanks for using it!", "Calculator Version 1.0" );
            MessageBoxResult result = MessageBox.Show("Do you want to close this Calculator?",
                                          "Confirmation",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }

        }

        private void btCE_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            if(operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
        }

        private void txtDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
