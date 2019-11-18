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
        double number1 = 0;
        double number2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiButtonClicked = false;
        bool divideButtonClicked = false;

        


        public MainWindow()
        {
           
            InitializeComponent();
        }


        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "1";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "2";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "3";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "4";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "5";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "6";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "7";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "8";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {

            txtDisplay.Text += "9";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "0";
            labelCurrentOperation.Content = txtDisplay.Text;
        }

        private void btPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.StartsWith("-"))
            {
                //It's negative now, so strip the `-` sign to make it positive
                txtDisplay.Text = txtDisplay.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(txtDisplay.Text) && decimal.Parse(txtDisplay.Text) != 0)
            {
                //It's positive now, so prefix the value with the `-` sign to make it negative
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btComma_Click(object sender, RoutedEventArgs e)
        {

            txtDisplay.Text += ",";

        }

        private void btEqual_Click(object sender, RoutedEventArgs e)
        {

            if(plusButtonClicked)
            {
                number2 = number1 + double.Parse(txtDisplay.Text);
                labelCurrentOperation.Content = number1 + "+" + double.Parse(txtDisplay.Text);
                txtDisplay.Text = number2.ToString();
                number1 = 0;
            }
        
            else if(minusButtonClicked)
            {
                number2 = number1 - double.Parse(txtDisplay.Text);
                labelCurrentOperation.Content = number1 + "-" + double.Parse(txtDisplay.Text);
                txtDisplay.Text = number2.ToString();
                number1 = 0;
            }
            else if(multiButtonClicked)
            {
                number2 = number1 * double.Parse(txtDisplay.Text);
                labelCurrentOperation.Content = number1 + "*" + double.Parse(txtDisplay.Text);
                txtDisplay.Text = number2.ToString();
                number1 = 0;
            }
            else if(divideButtonClicked)
            {
                number2 = number1 / double.Parse(txtDisplay.Text);
                labelCurrentOperation.Content = number1 + "/" + double.Parse(txtDisplay.Text);
                txtDisplay.Text = number2.ToString();
                number1 = 0;
            }

        }

        private void btPlus_Click(object sender, RoutedEventArgs e)
        {
            number1 += double.Parse(txtDisplay.Text);
            labelCurrentOperation.Content = txtDisplay.Text + "+";
            txtDisplay.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btMinus_Click(object sender, RoutedEventArgs e)
        {
            number1 -= double.Parse(txtDisplay.Text);
            labelCurrentOperation.Content = txtDisplay.Text + "-";
            txtDisplay.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btMulti_Click(object sender, RoutedEventArgs e)
        {
            number1 *= double.Parse(txtDisplay.Text);
            labelCurrentOperation.Content = txtDisplay.Text + "*";
            txtDisplay.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiButtonClicked = true;
            divideButtonClicked = false;
        }

        private void btDivide_Click(object sender, RoutedEventArgs e)
        {
            number1 /= double.Parse(txtDisplay.Text);
            labelCurrentOperation.Content = txtDisplay.Text + "/";
            txtDisplay.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiButtonClicked = false;
            divideButtonClicked = true;
        }

        private void btC_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            labelCurrentOperation.Content = "";
        }

        private void btCE_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            labelCurrentOperation.Content = "";
        }

        private void btBackSlash_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void txtDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //private void btBackSlash_Click(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = DecimalToString(number1);
        //    }
        //    else
        //    {
        //        number2 = DecimalToString(number2);
        //    }


        //}

        //private decimal DecimalToString(decimal number)
        //{
        //    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        //    string numberHolder = number.ToString();
        //    numberHolder = numberHolder.Substring(0, numberHolder.Length - 1);
        //    number = decimal.Parse(numberHolder);
        //    return number;
        //}




    }
}
