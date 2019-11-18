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

namespace Dice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dice1, dice2, dice3, dice4, dice5, totalResult;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRollDice_Click(object sender, RoutedEventArgs e)
        {
            int[] dices = new int[5];
            Random rndDice = new Random();
            dices[0] = rndDice.Next(1, 7);
            dices[1] = rndDice.Next(1, 7);
            dices[2] = rndDice.Next(1, 7);
            dices[3] = rndDice.Next(1, 7);
            dices[4] = rndDice.Next(1, 7);

            ResultDice1.Text = dices[0].ToString();
            ResultDice2.Text = dices[1].ToString();
            ResultDice3.Text = dices[2].ToString();
            ResultDice4.Text = dices[3].ToString();
            ResultDice5.Text = dices[4].ToString();

            foreach (var dice in dices)
            {
                totalResult += dice;
                txtDisplay.Text = totalResult.ToString();
                if(totalResult >= 20 && totalResult <=25)
                {
                    Result.Content = $"Wow you got a GOOD score of {totalResult}";
                }
                else if(totalResult >= 26)
                {
                    Result.Content = $"HOLY COW! You got a score over 26! Amazing!";
                }
                else
                {
                    Result.Content = "Decent score. Nothing special about it!";
                }
            }
            totalResult = 0;
        }

        

        private void TxtDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void _ResultDice1(object sender, TextChangedEventArgs e)
        {

        }

        private void _ResultDice2(object sender, TextChangedEventArgs e)
        {

        }

        private void _ResultDice3(object sender, TextChangedEventArgs e)
        {

        }

        private void _ResultDice4(object sender, TextChangedEventArgs e)
        {

        }

        private void _ResultDice5(object sender, TextChangedEventArgs e)
        {

        }
    }
}
