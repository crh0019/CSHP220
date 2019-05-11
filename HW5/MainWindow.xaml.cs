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

namespace HW5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int turn = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private string one;
        private string two;
        private string three;
        private string four;
        private string five;
        private string six;
        private string seven;
        private string eight;
        private string nine;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string player;
            turn++;

            if ( button.Content is null)
            {
                if (turn % 2 == 0)
                {
                    player = "O";
                }
                else
                {
                    player = "X";
                }

                button.Content = player;
                updateBoard(button);
                if (isWinner())
                {
                    DisableButtons();
                    MessageBox.Show("Winner " + player);
                }
            }

           
        }

        private void updateBoard(Button b)
        {
            if (b.Tag.ToString() == "0,0") { one = b.Content.ToString(); };
            if (b.Tag.ToString() == "0,1") { two = b.Content.ToString(); };
            if (b.Tag.ToString() == "0,2") { three = b.Content.ToString(); };
            if (b.Tag.ToString() == "1,0") { four = b.Content.ToString(); };
            if (b.Tag.ToString() == "1,1") { five = b.Content.ToString(); };
            if (b.Tag.ToString() == "1,2") { six = b.Content.ToString(); };
            if (b.Tag.ToString() == "2,0") { seven = b.Content.ToString(); };
            if (b.Tag.ToString() == "2,1") { eight = b.Content.ToString(); };
            if (b.Tag.ToString() == "2,2") { nine = b.Content.ToString(); };
        }

        private bool isWinner()
        {
            bool w = false;

            if (one == "X" && two =="X" && three =="X") { w = true; };
            if (one == "X" && four == "X" && seven == "X") { w = true; };
            if (one == "X" && five == "X" && nine == "X") { w = true; };
            if (two == "X" && five == "X" && eight == "X") { w = true; };
            if (three == "X" && five == "X" && seven == "X") { w = true; };
            if (three == "X" && six == "X" && nine == "X") { w = true; };
            if (four == "X" && five == "X" && six == "X") { w = true; };
            if (seven == "X" && eight == "X" && nine == "X") { w = true; };
            if (one == "O" && two == "O" && three == "O") { w = true; };
            if (one == "O" && four == "O" && seven == "O") { w = true; };
            if (one == "O" && five == "O" && nine == "O") { w = true; };
            if (two == "O" && five == "O" && eight == "O") { w = true; };
            if (three == "O" && five == "O" && seven == "O") { w = true; };
            if (three == "O" && six == "O" && nine == "O") { w = true; };
            if (four == "O" && five == "O" && six == "O") { w = true; };
            if (seven == "O" && eight == "O" && nine == "O") { w = true; };

            return w;
        }

        void DisableButtons()
        {
            UIElementCollection element = uxGrid.Children;
            List<FrameworkElement> elements = element.Cast<FrameworkElement>().ToList();
            List<Button> buttons = elements.OfType<Button>().ToList();

            foreach (Button b in buttons)
            {
                b.IsEnabled = false;
            }

        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            UIElementCollection element = uxGrid.Children;
            List<FrameworkElement> elements = element.Cast<FrameworkElement>().ToList();
            List<Button> buttons = elements.OfType<Button>().ToList();

            foreach (Button b in buttons)
            {
                b.Content = null;
                b.IsEnabled = true;
            }

            one = null;
            two = null;
            three = null;
            four = null;
            five = null;
            six = null;
            seven = null;
            eight = null;
            nine = null;

            turn = 0;
        }
    }
}
