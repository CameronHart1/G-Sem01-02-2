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

namespace HobanBookingSys
{
    /// <summary>
    /// Interaction logic for PopUpNewStudent.xaml
    /// </summary>
    public partial class PopUpNewStudent : Window
    {
        public string NameEnter
        { get; set; }

        public string EmailEnter
        { get; set; }


        public PopUpNewStudent()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameEnter = NameBox.Text.ToString();
            EmailEnter = EmailBox.Text.ToString();

            ConfrirmBut.IsEnabled = (NameEnter != "" && EmailEnter != "")? true : false;


        }

    }
}
