using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PostalCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// US Zip Codes ##### or #####-####
    ///Canadian Postal Codes: A#B#C#
    ///The window contains a Submit button that is only enabled when a valid zip code or postal code is entered.

    ///So for example, a user could enter 98122 or 98012-4444 or T1R2X4 and the Submit button would be enabled.
    /// </summary>
    public partial class MainWindow : Window
    {
        string REGX_US = @"^\d{5}(?:[-\s]\d{4})?$";
        string REGEX_CAN= @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtZipcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((!Regex.Match(txtZipcode.Text, REGX_US).Success) && (!Regex.Match(txtZipcode.Text, REGEX_CAN).Success))
            {
                btnSubmit.IsEnabled = false;
            }
            else
                btnSubmit.IsEnabled = true;
        }
    }
}
