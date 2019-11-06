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

namespace TextForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void YourMessage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            if(YourMessage.Text == "EasterEgg")
            {
                MessageBox.Show("You found the hidden text.. Gratz!");
                YourMessage.Text = "";
                AnswerBox.Text = "Activated our secret Box";
            }
            else if(YourMessage.Text == "Admin")
            {
                MessageBox.Show("Really? admin? cmon you are better then this..");
            }
            else
            {
                MessageBox.Show($"Sorry no treasure for you");
            }
            
        }

        private void Reply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A small Hint... Rabbit style?");
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AnswerBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}
