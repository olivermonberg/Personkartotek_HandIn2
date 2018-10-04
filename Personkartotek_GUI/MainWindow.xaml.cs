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
using DomaineModel;
using Infrastructure;

namespace Personkartotek_GUI
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

        PKDBUtil util = new PKDBUtil();

        private void AddPersonBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityBox.Text) || String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) || String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
                util.AddCityDB(ref c1);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text,StreetNumberBox.Text, c1);
                util.AddAddressDB(ref a1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

                Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
                util.AddPersonDB(ref p1);
            }
        }

        private void UpdatePersonInfoBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityBox.Text) || String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) || String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
                //util.AddCityDB(ref c1);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
                //util.AddAddressDB(ref a1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

                Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
                //util.AddPersonDB(ref p1);
                util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);

                //UpdatePersonInfoWindow w1 = new UpdatePersonInfoWindow();
                //w1.Show();

                
                //while (w1.ChangeBttnPressed == false)
                //{
                //    
                //}

                
                Person p2 = new Person(newFirstNameBox.Text, newLastNameBox.Text, newNationalityBox.Text,
                    newGenderBox.Text, a1);
                p2.PersonID = p1.PersonID;

                util.UpdatePersonDB(ref p2);

                //}
                //catch
                //{
                //    MessageBox.Show("Person not found. Please try again.");
                //    throw;
                //}


            }
        }
    }
}
