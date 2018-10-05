using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using DomaineModel;
using Infrastructure;

namespace Personkartotek_GUI
{
    /// <summary>
    /// Interaction logic for DeleteAA.xaml
    /// </summary>
    public partial class DeleteAA : Window
    {
        public DeleteAA()
        {
            InitializeComponent();
        }

        public static bool DeleteBttnPressed = false;
       private void AAList_Loaded(object sender, RoutedEventArgs e)
       {
           SqlConnection con;
           SqlCommand cmd;
           SqlDataReader dr;

           con = new SqlConnection(@"Data Source=10.83.16.131;Initial Catalog=E18I4DABau554208;User ID=E18I4DABau554208;Password=E18I4DABau554208;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

           cmd = new SqlCommand();
           con.Open();
           cmd.Connection = con;
           cmd.CommandText = "SELECT * FROM AlternativeAddress INNER JOIN Address ON Address.AddressID = " +
                             "AlternativeAddress.AddressID INNER JOIN City ON City.CityID = Address.CityID Inner join Person on Person.PersonID = AlternativeAddress.PersonID";

           dr = cmd.ExecuteReader();

           string str = "";

           while (dr.Read())
           {
               str += dr["StreetName"];
               str += ";";
               str += dr["StreetNumber"];
               str += ";";
               str += dr["CityName"];
               str += ";";
               str += dr["PostalCode"];
               str += ";";
               str += dr["Country"];
               str += ";";
               str += dr["Type"];
               str += ";";
               str += dr["FirstName"];
               str += ";";
               str += dr["LastName"];
               str += ";";
               str += dr["Nationality"];
               str += ";";
               str += dr["Gender"];

                AAList.Items.Add(str);
               str = "";
           }
           con.Close();
       }

        public string FirstName, LastName, Nationality, Gender = "";

       private void AAList_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {
           if (AAList.SelectedItem != null)
           {
               string[] strArray = AAList.SelectedItem.ToString().Split(';');

               
               StreetNameBox.Text = strArray[0];
               StreetNumberBox.Text = strArray[1];
               CityNameBox.Text = strArray[2];
               PostalCodeBox.Text = strArray[3];
               CountryBox.Text = strArray[4];
               TypeBox.Text = strArray[5];
               FirstName = strArray[6];
               LastName = strArray[7];
               Nationality = strArray[8];
               Gender = strArray[9];
            }
       }

       private void RefreshAADB_Click(object sender, RoutedEventArgs e)
       {
           AAList.Items.Clear();
           AAList_Loaded(sender, e);
       }

        public PKDBUtil util = new PKDBUtil();

        private void DeleteAABttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(CountryBox.Text) || String.IsNullOrEmpty(CityNameBox.Text) ||
                String.IsNullOrEmpty(PostalCodeBox.Text) ||
                String.IsNullOrEmpty(StreetNameBox.Text) || String.IsNullOrEmpty(StreetNumberBox.Text) ||
                String.IsNullOrEmpty(TypeBox.Text) )
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                City c1 = new City(CityNameBox.Text, PostalCodeBox.Text, CountryBox.Text);
                util.GetCityIDByCityNameAndPostalCodeAndCountry(ref c1);

                Address a1 = new Address(StreetNameBox.Text, StreetNumberBox.Text, c1);
                util.GetAddressIDByStreetNameAndStreetNumberAndCityID(ref a1);
                
                Person p1 = new Person(FirstName, LastName, Nationality,Gender, null);
                util.GetPersonIDByFirstNameAndLastNameAndNationalityAndGenderAndAddressID(ref p1);

                AlternativeAddress aa1 = new AlternativeAddress(p1,a1,TypeBox.Text);
                util.DeleteAlternativeAddressDB(ref aa1);

                
            }
        }
    }
}
