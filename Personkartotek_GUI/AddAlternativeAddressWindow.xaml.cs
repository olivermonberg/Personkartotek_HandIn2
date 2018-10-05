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
    /// Interaction logic for AddAlternativeAddressWindow.xaml
    /// </summary>
    public partial class AddAlternativeAddressWindow : Window
    {
        public AddAlternativeAddressWindow()
        {
            InitializeComponent();
        }

        public static bool AddBttnPressed = false;
        public static string Type, StreetName, StreetNumber, CityName, PostalCode, Country = "";

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(TypeBox.Text) || String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(CityNameBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) || String.IsNullOrEmpty(CountryBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {

                Type = TypeBox.Text;
                StreetName = StreetNameBox.Text;
                StreetNumber = StreetNumberBox.Text;
                CityName = CityNameBox.Text;
                PostalCode = PostalCodeBox.Text;
                Country = CountryBox.Text;

                AddBttnPressed = true;
                Close();
            }
        }
    }
}
