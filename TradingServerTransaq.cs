// Ignore Spelling: Transaq

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTransaqConnector.Structures;

namespace TestTransaqConnector
{
    public class TradingServerTransaq
    {
        /// <summary>
        /// Конструктор =======================================================================
        /// </summary>
        public TradingServerTransaq(string serverName, List<IPDomainPort> iPDomainPort)
        {
            _serverName = serverName;

            _ip_Domain = iPDomainPort;
        }


        /// <summary>
        /// Наименование сервера Transaq
        /// </summary>
        public string ServerName
        {
            get
            {
                return _serverName;
            }
        }

        string _serverName;

        /// <summary>
        /// Список серверов Transaq
        /// </summary>
        public List<IPDomainPort> IP_Domain
        {
            get
            {
                return _ip_Domain;
            }
        }
        List<IPDomainPort> _ip_Domain;


    }

}
