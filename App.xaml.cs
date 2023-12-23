using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TestTransaqConnector.Structures;

namespace TestTransaqConnector
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region===================================================Fields========================================================
        
        /// <summary>
        /// Список серверов Transaq с их параметрами
        /// </summary>
        public List<TradingServerTransaq> serversList = new List<TradingServerTransaq>();

        #endregion

        #region===================================================Methods=======================================================
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            TransaqServersRead();

            

            MainWindow wnd = new MainWindow();
                        
            wnd.Show();
        }

        /// <summary>
        /// КОСТЫЛЬ Чтение списка серверов и их параметров
        /// </summary>
        public void TransaqServersRead()
        {
            List<IPDomainPort>[] ipDomainList = new List<IPDomainPort>[3];
                        
            IPDomainPort ipDomain = new IPDomainPort();

            //======================================================================================

            ipDomainList[0] = new List<IPDomainPort>();
            
            ipDomain.IPDomain = "tr1.finam.ru";
            ipDomain.Port = 3900;
            ipDomainList[0].Add(ipDomain);

            ipDomain.IPDomain = "tr2.finam.online";
            ipDomain.Port = 3900;
            ipDomainList[0].Add(ipDomain);
                       
            serversList.Add(new TradingServerTransaq("АО \"Финам\"", ipDomainList[0]));

            //=====================================================================================
            
            ipDomainList[1] = new List<IPDomainPort>();
            
            ipDomain.IPDomain = "tr1-demo5.finam.ru";
            ipDomain.Port = 3939;
            ipDomainList[1].Add(ipDomain);

            serversList.Add(new TradingServerTransaq("Demo", ipDomainList[1]));

            //=======================================================================================

            ipDomainList[2] = new List<IPDomainPort>();

            ipDomain.IPDomain = "hft.finam.ru";
            ipDomain.Port = 13900;
            ipDomainList[2].Add(ipDomain);

            ipDomain.IPDomain = "hft1.finam.ru";
            ipDomain.Port = 13900;
            ipDomainList[2].Add(ipDomain);

            serversList.Add(new TradingServerTransaq("(HFT) АО \"Финам\"", ipDomainList[2]));

            //========================================================================================

            WriteServers(serversList);
        }

        /// <summary>
        /// Тест-метод выводит на экран все элементы tradingServersTransaq
        /// </summary>
        /// <param name="tradingServerTransaq"></param>
        public void WriteServers(List<TradingServerTransaq> tradingServerTransaq)
        {
            foreach (var i_item in tradingServerTransaq)
            {
                foreach (var j_item in i_item.IP_Domain)
                {
                    MessageBox.Show($"{i_item.ServerName} {j_item.IPDomain} : {j_item.Port}");
                }


            }
            
        }

        #endregion
    }
}
