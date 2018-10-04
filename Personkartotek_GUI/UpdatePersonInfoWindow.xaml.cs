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
    /// Interaction logic for UpdatePersonInfoWindow.xaml
    /// </summary>
    public partial class UpdatePersonInfoWindow : Window
    {
        public UpdatePersonInfoWindow()
        {
            InitializeComponent();
        }

        public bool ChangeBttnPressed = false;

        private void ChangePersonInfoBttn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(FirstNameBox.Text) || String.IsNullOrEmpty(LastNameBox.Text) || String.IsNullOrEmpty(NationalityBox.Text) || String.IsNullOrEmpty(GenderBox.Text))
            {
                MessageBox.Show("Information is missing. Please try again.");
            }
            else
            {
                ChangeBttnPressed = true;
                
            }
        }
    }
}
