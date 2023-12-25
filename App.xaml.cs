// Ignore Spelling: App

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestTransaqConnector
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region===================================================Fields========================================================

        public MainWindow mainWindow = new MainWindow();

        #endregion

        #region===================================================Methods=======================================================
        public void Application_Startup(object sender, StartupEventArgs e)
        {
                                   
            mainWindow.Show();
                        
        }
               

        #endregion
    }
}
