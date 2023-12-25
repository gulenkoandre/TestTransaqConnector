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
using TestTransaqConnector.Structures;


namespace TestTransaqConnector
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region================================================Constructor==================================================

        public MainWindow()
        {
            _connectionLogin.tradingServerSelected = 0;

            _connectionLogin.login = "";

            _connectionLogin.password = "";

            InitializeComponent();
        }

        #endregion

        #region==================================================Properties===================================================
        /*public ConnectionLogin ConnectionLogin
        {
            get
            {
                return _connectionLogin;
            }
            set
            {
                _connectionLogin = value;
            }
        }*/

        #endregion

        #region====================================================Fields===================================================

        public ConnectionLogin _connectionLogin = new ConnectionLogin();
        
        #endregion

        #region====================================================Methods==================================================
        /// <summary>
        /// Меню Connection - Open Connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenConnection_Click(object sender, RoutedEventArgs e)
        {
            WindowOpenConnection windowOpenConnection = new WindowOpenConnection(_connectionLogin);
                        
            windowOpenConnection.ShowDialog();
            
        }

        // <summary>
        /// Меню Connection - Close Connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseConnection_Click(object sender, RoutedEventArgs e)
        {
            
        }
        #endregion
    }
}
