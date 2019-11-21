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
        int totalResult;
        int highScore;
        
        
        
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

            

            //ResultDice1.Text = dices[0].ToString();
            //ResultDice2.Text = dices[1].ToString();
            //ResultDice3.Text = dices[2].ToString();
            //ResultDice4.Text = dices[3].ToString();
            //ResultDice5.Text = dices[4].ToString();

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
                else if (totalResult <10)
                {
                    Result.Content = $"Jeesus thats a low result. Hard to get that low!";
                }
                else
                {
                    Result.Content = "Decent score. Nothing special about it!";
                }
              
                #region DICE1
                if (dices[0] == 1)
                {
                    Dice1Image1.Visibility = Visibility.Visible;
                    Dice1Image2.Visibility = Visibility.Hidden;
                    Dice1Image3.Visibility = Visibility.Hidden;
                    Dice1Image4.Visibility = Visibility.Hidden;
                    Dice1Image5.Visibility = Visibility.Hidden;
                    Dice1Image6.Visibility = Visibility.Hidden;

                }
                else if(dices[0] == 2)
                {
                    Dice1Image1.Visibility = Visibility.Hidden;
                    Dice1Image2.Visibility = Visibility.Visible;
                    Dice1Image3.Visibility = Visibility.Hidden;
                    Dice1Image4.Visibility = Visibility.Hidden;
                    Dice1Image5.Visibility = Visibility.Hidden;
                    Dice1Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[0] == 3)
                {
                    Dice1Image1.Visibility = Visibility.Hidden;
                    Dice1Image2.Visibility = Visibility.Hidden;
                    Dice1Image3.Visibility = Visibility.Visible;
                    Dice1Image4.Visibility = Visibility.Hidden;
                    Dice1Image5.Visibility = Visibility.Hidden;
                    Dice1Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[0] == 4)
                {
                    Dice1Image1.Visibility = Visibility.Hidden;
                    Dice1Image2.Visibility = Visibility.Hidden;
                    Dice1Image3.Visibility = Visibility.Hidden;
                    Dice1Image4.Visibility = Visibility.Visible;
                    Dice1Image5.Visibility = Visibility.Hidden;
                    Dice1Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[0] == 5)
                {
                    Dice1Image1.Visibility = Visibility.Hidden;
                    Dice1Image2.Visibility = Visibility.Hidden;
                    Dice1Image3.Visibility = Visibility.Hidden;
                    Dice1Image4.Visibility = Visibility.Hidden;
                    Dice1Image5.Visibility = Visibility.Visible;
                    Dice1Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[0] == 6)
                {
                    Dice1Image1.Visibility = Visibility.Hidden;
                    Dice1Image2.Visibility = Visibility.Hidden;
                    Dice1Image3.Visibility = Visibility.Hidden;
                    Dice1Image4.Visibility = Visibility.Hidden;
                    Dice1Image5.Visibility = Visibility.Hidden;
                    Dice1Image6.Visibility = Visibility.Visible;
                }
                #endregion
                #region DICE2
                if (dices[1] == 1)
                {
                    Dice2Image1.Visibility = Visibility.Visible;
                    Dice2Image2.Visibility = Visibility.Hidden;
                    Dice2Image3.Visibility = Visibility.Hidden;
                    Dice2Image4.Visibility = Visibility.Hidden;
                    Dice2Image5.Visibility = Visibility.Hidden;
                    Dice2Image6.Visibility = Visibility.Hidden;

                }
                else if (dices[1] == 2)
                {
                    Dice2Image1.Visibility = Visibility.Hidden;
                    Dice2Image2.Visibility = Visibility.Visible;
                    Dice2Image3.Visibility = Visibility.Hidden;
                    Dice2Image4.Visibility = Visibility.Hidden;
                    Dice2Image5.Visibility = Visibility.Hidden;
                    Dice2Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[1] == 3)
                {
                    Dice2Image1.Visibility = Visibility.Hidden;
                    Dice2Image2.Visibility = Visibility.Hidden;
                    Dice2Image3.Visibility = Visibility.Visible;
                    Dice2Image4.Visibility = Visibility.Hidden;
                    Dice2Image5.Visibility = Visibility.Hidden;
                    Dice2Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[1] == 4)
                {
                    Dice2Image1.Visibility = Visibility.Hidden;
                    Dice2Image2.Visibility = Visibility.Hidden;
                    Dice2Image3.Visibility = Visibility.Hidden;
                    Dice2Image4.Visibility = Visibility.Visible;
                    Dice2Image5.Visibility = Visibility.Hidden;
                    Dice2Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[1] == 5)
                {
                    Dice2Image1.Visibility = Visibility.Hidden;
                    Dice2Image2.Visibility = Visibility.Hidden;
                    Dice2Image3.Visibility = Visibility.Hidden;
                    Dice2Image4.Visibility = Visibility.Hidden;
                    Dice2Image5.Visibility = Visibility.Visible;
                    Dice2Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[1] == 6)
                {
                    Dice2Image1.Visibility = Visibility.Hidden;
                    Dice2Image2.Visibility = Visibility.Hidden;
                    Dice2Image3.Visibility = Visibility.Hidden;
                    Dice2Image4.Visibility = Visibility.Hidden;
                    Dice2Image5.Visibility = Visibility.Hidden;
                    Dice2Image6.Visibility = Visibility.Visible;
                }
                #endregion
                #region DICE3
                if (dices[2] == 1)
                {
                    Dice3Image1.Visibility = Visibility.Visible;
                    Dice3Image2.Visibility = Visibility.Hidden;
                    Dice3Image3.Visibility = Visibility.Hidden;
                    Dice3Image4.Visibility = Visibility.Hidden;
                    Dice3Image5.Visibility = Visibility.Hidden;
                    Dice3Image6.Visibility = Visibility.Hidden;

                }
                else if (dices[2] == 2)
                {
                    Dice3Image1.Visibility = Visibility.Hidden;
                    Dice3Image2.Visibility = Visibility.Visible;
                    Dice3Image3.Visibility = Visibility.Hidden;
                    Dice3Image4.Visibility = Visibility.Hidden;
                    Dice3Image5.Visibility = Visibility.Hidden;
                    Dice3Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[2] == 3)
                {
                    Dice3Image1.Visibility = Visibility.Hidden;
                    Dice3Image2.Visibility = Visibility.Hidden;
                    Dice3Image3.Visibility = Visibility.Visible;
                    Dice3Image4.Visibility = Visibility.Hidden;
                    Dice3Image5.Visibility = Visibility.Hidden;
                    Dice3Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[2] == 4)
                {
                    Dice3Image1.Visibility = Visibility.Hidden;
                    Dice3Image2.Visibility = Visibility.Hidden;
                    Dice3Image3.Visibility = Visibility.Hidden;
                    Dice3Image4.Visibility = Visibility.Visible;
                    Dice3Image5.Visibility = Visibility.Hidden;
                    Dice3Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[2] == 5)
                {
                    Dice3Image1.Visibility = Visibility.Hidden;
                    Dice3Image2.Visibility = Visibility.Hidden;
                    Dice3Image3.Visibility = Visibility.Hidden;
                    Dice3Image4.Visibility = Visibility.Hidden;
                    Dice3Image5.Visibility = Visibility.Visible;
                    Dice3Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[2] == 6)
                {
                    Dice3Image1.Visibility = Visibility.Hidden;
                    Dice3Image2.Visibility = Visibility.Hidden;
                    Dice3Image3.Visibility = Visibility.Hidden;
                    Dice3Image4.Visibility = Visibility.Hidden;
                    Dice3Image5.Visibility = Visibility.Hidden;
                    Dice3Image6.Visibility = Visibility.Visible;
                }
                #endregion
                #region DICE4
                if (dices[3] == 1)
                {
                    Dice4Image1.Visibility = Visibility.Visible;
                    Dice4Image2.Visibility = Visibility.Hidden;
                    Dice4Image3.Visibility = Visibility.Hidden;
                    Dice4Image4.Visibility = Visibility.Hidden;
                    Dice4Image5.Visibility = Visibility.Hidden;
                    Dice4Image6.Visibility = Visibility.Hidden;

                }
                else if (dices[3] == 2)
                {
                    Dice4Image1.Visibility = Visibility.Hidden;
                    Dice4Image2.Visibility = Visibility.Visible;
                    Dice4Image3.Visibility = Visibility.Hidden;
                    Dice4Image4.Visibility = Visibility.Hidden;
                    Dice4Image5.Visibility = Visibility.Hidden;
                    Dice4Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[3] == 3)
                {
                    Dice4Image1.Visibility = Visibility.Hidden;
                    Dice4Image2.Visibility = Visibility.Hidden;
                    Dice4Image3.Visibility = Visibility.Visible;
                    Dice4Image4.Visibility = Visibility.Hidden;
                    Dice4Image5.Visibility = Visibility.Hidden;
                    Dice4Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[3] == 4)
                {
                    Dice4Image1.Visibility = Visibility.Hidden;
                    Dice4Image2.Visibility = Visibility.Hidden;
                    Dice4Image3.Visibility = Visibility.Hidden;
                    Dice4Image4.Visibility = Visibility.Visible;
                    Dice4Image5.Visibility = Visibility.Hidden;
                    Dice4Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[3] == 5)
                {
                    Dice4Image1.Visibility = Visibility.Hidden;
                    Dice4Image2.Visibility = Visibility.Hidden;
                    Dice4Image3.Visibility = Visibility.Hidden;
                    Dice4Image4.Visibility = Visibility.Hidden;
                    Dice4Image5.Visibility = Visibility.Visible;
                    Dice4Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[3] == 6)
                {
                    Dice4Image1.Visibility = Visibility.Hidden;
                    Dice4Image2.Visibility = Visibility.Hidden;
                    Dice4Image3.Visibility = Visibility.Hidden;
                    Dice4Image4.Visibility = Visibility.Hidden;
                    Dice4Image5.Visibility = Visibility.Hidden;
                    Dice4Image6.Visibility = Visibility.Visible;
                }
                #endregion
                #region DICE5
                if (dices[4] == 1)
                {
                    Dice5Image1.Visibility = Visibility.Visible;
                    Dice5Image2.Visibility = Visibility.Hidden;
                    Dice5Image3.Visibility = Visibility.Hidden;
                    Dice5Image4.Visibility = Visibility.Hidden;
                    Dice5Image5.Visibility = Visibility.Hidden;
                    Dice5Image6.Visibility = Visibility.Hidden;

                }
                else if (dices[4] == 2)
                {
                    Dice5Image1.Visibility = Visibility.Hidden;
                    Dice5Image2.Visibility = Visibility.Visible;
                    Dice5Image3.Visibility = Visibility.Hidden;
                    Dice5Image4.Visibility = Visibility.Hidden;
                    Dice5Image5.Visibility = Visibility.Hidden;
                    Dice5Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[4] == 3)
                {
                    Dice5Image1.Visibility = Visibility.Hidden;
                    Dice5Image2.Visibility = Visibility.Hidden;
                    Dice5Image3.Visibility = Visibility.Visible;
                    Dice5Image4.Visibility = Visibility.Hidden;
                    Dice5Image5.Visibility = Visibility.Hidden;
                    Dice5Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[4] == 4)
                {
                    Dice5Image1.Visibility = Visibility.Hidden;
                    Dice5Image2.Visibility = Visibility.Hidden;
                    Dice5Image3.Visibility = Visibility.Hidden;
                    Dice5Image4.Visibility = Visibility.Visible;
                    Dice5Image5.Visibility = Visibility.Hidden;
                    Dice5Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[4] == 5)
                {
                    Dice5Image1.Visibility = Visibility.Hidden;
                    Dice5Image2.Visibility = Visibility.Hidden;
                    Dice5Image3.Visibility = Visibility.Hidden;
                    Dice5Image4.Visibility = Visibility.Hidden;
                    Dice5Image5.Visibility = Visibility.Visible;
                    Dice5Image6.Visibility = Visibility.Hidden;
                }
                else if (dices[4] == 6)
                {
                    Dice5Image1.Visibility = Visibility.Hidden;
                    Dice5Image2.Visibility = Visibility.Hidden;
                    Dice5Image3.Visibility = Visibility.Hidden;
                    Dice5Image4.Visibility = Visibility.Hidden;
                    Dice5Image5.Visibility = Visibility.Hidden;
                    Dice5Image6.Visibility = Visibility.Visible;
                }
                #endregion
                
            }

            if (totalResult > highScore)
            {
                Highscore.Text = totalResult.ToString();
                highScore = totalResult;
                Result.Content = $"NEW HIGHSCORE! AWESOME! Your score is {totalResult}";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("highScore.wav");
                player.Play();
            }
            totalResult = 0;
        }

        

        private void TxtDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Behaviour_TextChanged(object sender, TextChangedEventArgs e)
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
