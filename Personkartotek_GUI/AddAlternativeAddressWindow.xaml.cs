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
using Infrastructure;

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

        PKDBUtil util = new PKDBUtil();

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

       

        /*
        private void AAList_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;

            con = new SqlConnection(@"Data Source=10.83.16.131;Initial Catalog=E18I4DABau554208;User ID=E18I4DABau554208;Password=E18I4DABau554208;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM AlternativeAddress INNER JOIN Person ON Person.PersonID = AlternativeAddress.PersonID " +
                              "INNER JOIN Address ON Address.AddressID = AlternativeAddress.AddressID " +
                              "WHERE(Person.PersonID = 11)";
            //string st = MainWindow.FirstNameBox.Text;

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

                AAList.Items.Add(str);
                str = "";
            }
            con.Close();
        }

        private void AAList_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void RefreshAADB_Click(object sender, RoutedEventArgs e)
        {
            PersonsList.Items.Clear();
            PersonsList_Loaded(sender, e);
        }*/
    }
}
