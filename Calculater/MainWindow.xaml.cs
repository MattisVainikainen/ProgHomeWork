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
        long number1 = 0;
        long number2 = 0;

        string operation = "";
        List<long> listOfNumbers = new List<long>();

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
                listOfNumbers.Add(number1);


            }
            else 
            {
                number2 = number2 * 10 + btnNum;
                txtDisplay.Text = number2.ToString();
                listOfNumbers.Add(number2);
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

        }

        private void btComma_Click(object sender, RoutedEventArgs e)
        {

        }

        //Kan inte göra en ny beräkning efter = tecknet.
        private void btEqual_Click(object sender, RoutedEventArgs e)
        {
           
            switch(operation) 
            {
                case "+":
                   
                    txtDisplay.Text = (number1 + number2).ToString();
                    labelCurrentOperation.Content = $"{number1} + {number2} = {txtDisplay.Text}";                  
                    break;

                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    labelCurrentOperation.Content = $"{number1} - {number2} = {txtDisplay.Text}";
                    break;

                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    labelCurrentOperation.Content = $"{number1} * {number2} = {txtDisplay.Text}";
                    break;
            }
           

        }

        private void btDivide_Click(object sender, RoutedEventArgs e)
        {

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

        }

        private void btC_Click(object sender, RoutedEventArgs e)
        {
            operation = "";
            labelCurrentOperation.Content = "";
            txtDisplay.Text = "0";
            number1 = 0;
            number2 = 0;
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
