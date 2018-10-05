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
using System.Windows.Shapes;

namespace Personkartotek_GUI
{
    /// <summary>
    /// Interaction logic for ChangePersonsPrimaryAddressWindow.xaml
    /// </summary>
    public partial class ChangePersonsPrimaryAddressWindow : Window
    {
        public ChangePersonsPrimaryAddressWindow()
        {
            InitializeComponent();
        }
        public static bool ChangeBttnPressed = false;
        public static string StreetName, StreetNumber, CityName, PostalCode, Country = "";

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) || String.IsNullOrEmpty(CityNameBox.Text) || 
                String.IsNullOrEmpty(PostalCodeBox.Text) || String.IsNullOrEmpty(CountryBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                StreetName = StreetNameBox.Text;
                StreetNumber = StreetNumberBox.Text;
                CityName = CityNameBox.Text;
                PostalCode = PostalCodeBox.Text;
                Country = CountryBox.Text;

                ChangeBttnPressed = true;
                Close();
            }
        }
    }
}
