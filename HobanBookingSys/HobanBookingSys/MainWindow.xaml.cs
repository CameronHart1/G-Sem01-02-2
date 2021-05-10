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
using HobanBookingSys.Classes;

namespace HobanBookingSys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        AccountDataDB RefAcountDB = (AccountDataDB)App.Current.Properties["AccountDataDB"];

        bool AccountFound;

        public MainWindow()
        {
            InitializeComponent();


        }

        // When the KeyId box is updated checks if an account with that user is found, if not or if it is a student account it greys out the Password bar
        void KeyIdBox_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (RefAcountDB.FindAccount(KeyIdBox.Text.ToString()).IsOrganizer)
                {
                    PasswordBox.IsEnabled = true;
                    LoginLabelTwo.IsEnabled = true;
                }
                else
                {
                    PasswordBox.IsEnabled = false;
                    LoginLabelTwo.IsEnabled = false;
                }
                AccountFound = true;

            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
                AccountFound = false;
            }
        }

        void LoginButton_Click(object sender, EventArgs e)
        {

            if (AccountFound)
            {
                Account TmpAccount = RefAcountDB.FindAccount(KeyIdBox.Text.ToString());

                if (TmpAccount.IsOrganizer)
                {
                    try
                    {
                        App.Current.Properties["AccessedAccount"] = RefAcountDB.Login(KeyIdBox.Text.ToString(), PasswordBox.Password.ToString());

                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    App.Current.Properties["AccessedAccount"] = RefAcountDB.Login(KeyIdBox.Text.ToString());
                }


            }
            else
            {
                MessageBox.Show("Account not found");
            }
        }

    }
}
