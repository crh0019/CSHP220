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
