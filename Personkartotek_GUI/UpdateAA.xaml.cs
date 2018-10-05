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
    /// Interaction logic for UpdateAA.xaml
    /// </summary>
    public partial class UpdateAA : Window
    {
        public UpdateAA()
        {
            InitializeComponent();
        }

        public static bool ChangeBttnPressed = false;
        public static string Type, StreetName, StreetNumber, CityName, PostalCode, Country = "";
        public static string newType, newStreetName, newStreetNumber, newCityName, newPostalCode, newCountry = "";

        private void Change_Click(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrEmpty(TypeBox.Text) || String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(CityNameBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) || String.IsNullOrEmpty(CountryBox.Text) || 
                String.IsNullOrEmpty(newTypeBox.Text) || String.IsNullOrEmpty(newStreetNameBox.Text) || String.IsNullOrEmpty(newStreetNumberBox.Text) ||
                String.IsNullOrEmpty(newCityNameBox.Text) ||
                String.IsNullOrEmpty(newPostalCodeBox.Text) || String.IsNullOrEmpty(newCountryBox.Text))
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

                newType = newTypeBox.Text;
                newStreetName = newStreetNameBox.Text;
                newStreetNumber = newStreetNumberBox.Text;
                newCityName = newCityNameBox.Text;
                newPostalCode = newPostalCodeBox.Text;
                newCountry = newCountryBox.Text;

                ChangeBttnPressed = true;
                Close();
            }
        }
    }
}
