using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
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
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) ||
                String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
                util.AddCityDB(ref c1);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
                util.AddAddressDB(ref a1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

                Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
                util.AddPersonDB(ref p1);
            }
        }

        private void UpdatePersonInfoBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) ||
                String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

                Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
                util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);

                Thread viewerThread = new Thread(delegate()
                {
                    UpdatePersonInfoWindow w1 = new UpdatePersonInfoWindow();
                    w1.Show();
                    System.Windows.Threading.Dispatcher.Run();
                });

                viewerThread.SetApartmentState(ApartmentState.STA);
                viewerThread.Start();

                UpdatePersonInfoWindow.ChangeBttnPressed = false;

                while (UpdatePersonInfoWindow.ChangeBttnPressed == false)
                {
                }

                

                Person p2 = new Person(UpdatePersonInfoWindow.FirstName, UpdatePersonInfoWindow.LastName,
                    UpdatePersonInfoWindow.Nationality, UpdatePersonInfoWindow.Gender, a1);
                p2.PersonID = p1.PersonID;

                util.UpdatePersonDB(ref p2);
            }
        }

        private void DeletePersonBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) ||
                String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

                Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
                util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);
                util.DeletePersonDB(ref p1);
            }
        }

        private void ChangePersonsPrimaryAddressBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) ||
                String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

                Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
                util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);

                Thread viewerThread = new Thread(delegate()
                {
                    ChangePersonsPrimaryAddressWindow w1 = new ChangePersonsPrimaryAddressWindow();
                    w1.Show();
                    System.Windows.Threading.Dispatcher.Run();
                });

                viewerThread.SetApartmentState(ApartmentState.STA);
                viewerThread.Start();

                ChangePersonsPrimaryAddressWindow.ChangeBttnPressed = false;

                while (ChangePersonsPrimaryAddressWindow.ChangeBttnPressed == false)
                {
                }

                

                City c2 = new City(ChangePersonsPrimaryAddressWindow.CityName,
                    ChangePersonsPrimaryAddressWindow.PostalCode, ChangePersonsPrimaryAddressWindow.Country);
                util.AddCityDB(ref c2);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c2);

                Address a2 = new Address(ChangePersonsPrimaryAddressWindow.StreetName,
                    ChangePersonsPrimaryAddressWindow.StreetNumber, c2);
                util.AddAddressDB(ref a2);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a2);

                p1.AddressID = a2.AddressID;
                util.UpdatePersonDB(ref p1);
            }
        }

        private void AddAlternativeAddressBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) ||
                String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

                Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
                util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);

                Thread viewerThread = new Thread(delegate()
                {
                    AddAlternativeAddressWindow w1 = new AddAlternativeAddressWindow();
                    w1.Show();
                    System.Windows.Threading.Dispatcher.Run();
                });

                viewerThread.SetApartmentState(ApartmentState.STA);
                viewerThread.Start();

                AddAlternativeAddressWindow.AddBttnPressed = false;

                while (AddAlternativeAddressWindow.AddBttnPressed == false)
                {
                }

                City c2 = new City(AddAlternativeAddressWindow.CityName, AddAlternativeAddressWindow.PostalCode,
                    AddAlternativeAddressWindow.Country);
                util.AddCityDB(ref c2);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c2);

                Address a2 = new Address(AddAlternativeAddressWindow.StreetName,
                    AddAlternativeAddressWindow.StreetNumber, c2);
                util.AddAddressDB(ref a2);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a2);

                AlternativeAddress aa1 = new AlternativeAddress(p1, a2, AddAlternativeAddressWindow.Type);
                util.AddAlternativeAddressDB(ref aa1);
            }
        }

        private void PersonsList_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            
            con = new SqlConnection(@"Data Source=10.83.16.131;Initial Catalog=E18I4DABau554208;User ID=E18I4DABau554208;Password=E18I4DABau554208;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Person INNER JOIN Address ON Address.AddressID = Person.AddressID INNER JOIN City ON City.CityID = Address.CityID";
            dr = cmd.ExecuteReader();

            string str = "";

            while (dr.Read())
            {
                str += dr["FirstName"];
                str += ";";
                str += dr["LastName"];
                str += ";";
                str += dr["Nationality"];
                str += ";";
                str += dr["Gender"];
                str += ";";
                str += dr["StreetName"];
                str += ";";
                str += dr["StreetNumber"];
                str += ";";
                str += dr["CityName"];
                str += ";";
                str += dr["PostalCode"];
                str += ";";
                str += dr["Country"];

                PersonsList.Items.Add(str);
                str = "";
            }
            con.Close();
        }

        private void PersonsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PersonsList.SelectedItem != null)
            {
                string[] strArray = PersonsList.SelectedItem.ToString().Split(';');

                FirstNameBox.Text = strArray[0];
                LastNameBox.Text = strArray[1];
                NationalityBox.Text = strArray[2];
                GenderBox.Text = strArray[3];
                StreetNameBox.Text = strArray[4];
                StreetNumberBox.Text = strArray[5];
                CityBox.Text = strArray[6];
                PostalCodeBox.Text = strArray[7];
                CountryBox.Text = strArray[8];
            }
    }

        private void RefreshDB_Click(object sender, RoutedEventArgs e)
        {
            PersonsList.Items.Clear();
            PersonsList_Loaded(sender,e);
        }

        private void ChangeAlternativeAddressBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) ||
                String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

                Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
                util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);

                Thread viewerThread = new Thread(delegate()
                {
                    UpdateAA w1 = new UpdateAA();
                    w1.Show();
                    System.Windows.Threading.Dispatcher.Run();
                });

                viewerThread.SetApartmentState(ApartmentState.STA);
                viewerThread.Start();

                UpdateAA.ChangeBttnPressed = false;

                while (UpdateAA.ChangeBttnPressed == false)
                {
                }



                City c2 = new City(UpdateAA.CityName, UpdateAA.PostalCode, UpdateAA.Country);
                util.AddCityDB(ref c2);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c2);

                Address a2 = new Address(UpdateAA.StreetName, UpdateAA.StreetNumber, c2);
                util.AddAddressDB(ref a2);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a2);

                AlternativeAddress aa1 = new AlternativeAddress(p1,a2,UpdateAA.Type);
                util.GetAlternativeAddressIDByPersonAndAddressAndType(ref aa1);

              

                City c3 = new City(UpdateAA.newCityName, UpdateAA.newPostalCode, UpdateAA.newCountry);
                util.AddCityDB(ref c3);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c3);

                Address a3 = new Address(UpdateAA.newStreetName, UpdateAA.newStreetNumber, c3);
                util.AddAddressDB(ref a3);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a3);

                //a2.AddressID = a3.AddressID;
                AlternativeAddress aa2 = new AlternativeAddress(p1, a3, UpdateAA.newType);
                
                aa2.AlternativeAddressID = aa1.AlternativeAddressID;
                

                util.UpdateAlternativeAddressDB(ref aa2);
                /*
                aa1.AddressID = a2.AddressID;
                util.AddAlternativeAddressDB(ref aa1);
                util.GetAlternativeAddressIDByPersonAndAddressAndType(ref aa1);*/


                //util.UpdateAlternativeAddressDB(ref aa1);
            }
        }

        public static long PersonID = 0;

        private void DeleteAlternativeAddressBttn_Click(object sender, RoutedEventArgs e)
        {
            City c1 = new City(CityBox.Text, PostalCodeBox.Text, CountryBox.Text);
            util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

            Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
            util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);

            Person p1 = new Person(FirstNameBox.Text, LastNameBox.Text, NationalityBox.Text, GenderBox.Text, a1);
            util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);

            PersonID = p1.PersonID;

            Thread viewerThread = new Thread(delegate ()
            {
                DeleteAA w1 = new DeleteAA();
                w1.Show();
                System.Windows.Threading.Dispatcher.Run();
            });

            viewerThread.SetApartmentState(ApartmentState.STA);
            viewerThread.Start();

            DeleteAA.DeleteBttnPressed = false;

            while (DeleteAA.DeleteBttnPressed == false)
            {
            }

            


            City c2 = new City(DeleteAA.CityName, DeleteAA.PostalCode, DeleteAA.Country);
            util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c2);
            Address a2 = new Address(DeleteAA.StreetName, DeleteAA.StreetNumber, c2);
            util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a2);

            AlternativeAddress aa1 = new AlternativeAddress(p1, a2, DeleteAA.Type);
            util.GetAlternativeAddressIDByPersonAndAddressAndType(ref aa1);
            util.DeleteAlternativeAddressDB(ref aa1);

        }
    }
}
