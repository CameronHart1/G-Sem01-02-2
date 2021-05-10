using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HobanBookingSys.Classes;

namespace HobanBookingSys
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // on startup we create an instance of AccountData that is stored in Properties, That means it is avaliable for all Pages to use.
        void Application_Startup(object sender, StartupEventArgs e)
        {
            this.Properties["AccountDataDB"] = new AccountDataDB();
        }
    }
}
