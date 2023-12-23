using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTransaqConnector.Structures
{
    /// <summary>
    /// Пара IP/Domain + Port используется в списке для каждого из серверов в классе TradingServer Transaq
    /// </summary>
    public struct IPDomainPort
    {
        public string IPDomain;
        public int Port;
    }
}
