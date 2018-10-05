using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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
    /// Interaction logic for UpdatePersonInfoWindow.xaml
    /// </summary>
    public partial class UpdatePersonInfoWindow : Window
    {
        public UpdatePersonInfoWindow()
        {
            InitializeComponent();
        }

        public static bool ChangeBttnPressed = false;
        public static string FirstName, LastName, Nationality, Gender = "";

        private void ChangePersonInfoBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) || String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                FirstName = FirstNameBox.Text;
                LastName = LastNameBox.Text;
                Nationality = NationalityBox.Text;
                Gender = GenderBox.Text;

                ChangeBttnPressed = true;
                Close();
            }
        }
    }
}
