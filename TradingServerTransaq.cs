// Ignore Spelling: Transaq

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTransaqConnector
{
    public class TradingServerTransaq
    {
        /// <summary>
        /// Конструктор =======================================================================
        /// </summary>
        public TradingServerTransaq()
        {
            
        }

        #region=========================================Properties============================================

        /// <summary>
        /// Наименование сервера Transaq
        /// </summary>
        public string ServerName { get; set; }
                
        /// <summary>
        /// IP/Domain Transaq
        /// </summary>
        public string IPDomain { get; set; }
        
        /// <summary>
        /// Port для IP/Domain Transaq
        /// </summary>
        public string Port { get; set; }

        #endregion

        #region=======================================Methods===============================================
                
        public override string ToString() => $"{ServerName} - {IPDomain} : {Port}";
        

        #endregion
    }

}
