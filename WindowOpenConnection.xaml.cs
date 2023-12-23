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

namespace TestTransaqConnector
{
    /// <summary>
    /// Логика взаимодействия для WindowOpenConnection.xaml
    /// </summary>
    public partial class WindowOpenConnection : Window
    {
        public WindowOpenConnection()
        {
            InitializeComponent();

            //выпадающий список серверов в ComboBox
            serversComboBox.ItemsSource = new TradingServerTransaq[]
            {
                new TradingServerTransaq { ServerName="AO \"Финам\"", IPDomain="tr1.finam.ru", Port="3900" },
                new TradingServerTransaq { ServerName="AO \"Финам\"", IPDomain="tr2.finam.online", Port="3900" },
                new TradingServerTransaq { ServerName="(HFT) AO \"Финам\"", IPDomain="hft.finam.ru", Port="13900" },
                new TradingServerTransaq { ServerName="(HFT) AO \"Финам\"", IPDomain="hft1.finam.ru", Port="13900" },
                new TradingServerTransaq { ServerName="Demo", IPDomain="tr1-demo5.finam.ru", Port="3939" }
            };

            serversComboBox.SelectedIndex = 3;
        }
    }
}
