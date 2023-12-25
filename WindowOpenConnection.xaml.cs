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
        #region================================================Constructor=============================================
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

            serversComboBox.SelectedIndex = 0;
        }
        #endregion

        #region================================================Fields===================================================

        private bool passwordBox_Flag=false; //флаг - поле пароля не пустое = true, иначе = false

        #endregion

        #region=============================================Methods=======================================================

        /// <summary>
        /// Обработчик поля ввода Password - видимый/невидимый
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordVisible_Click(object sender, RoutedEventArgs e)
        {
            if (passVisibleImage.Visibility.ToString() == "Hidden") //если Состояние - пароль скрыт
            {
                //сделать пароль видимым
                passwordTextBox.Text = passwordPassBox.Password;

                passwordPassBox.Visibility = Visibility.Hidden;

                passwordTextBox.Visibility = Visibility.Visible;

                passUnVisibleImage.Visibility = Visibility.Hidden;

                passVisibleImage.Visibility = Visibility.Visible;
            }
            else // если пароль виден
            {
                // сделать пароль невидимым
                passwordPassBox.Password = passwordTextBox.Text;

                passwordTextBox.Visibility = Visibility.Hidden;

                passwordPassBox.Visibility = Visibility.Visible;

                passVisibleImage.Visibility = Visibility.Hidden;

                passUnVisibleImage.Visibility = Visibility.Visible;

            }
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            connectingButton_Enable_Disable();
        }

        private void passwordPassBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            passwordBox_Flag = passwordPassBox.Password!="" ;

            connectingButton_Enable_Disable();
        }

        private void passwordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            passwordBox_Flag = passwordTextBox.Text != "";

            connectingButton_Enable_Disable();
        }

        /// <summary>
        /// Включение/выключение активности кнопки Connecting, если оба поля login и password не пустые, то вкл, иначе - выкл
        /// </summary>
        private void connectingButton_Enable_Disable()
        {            
            if (passwordBox_Flag && loginTextBox.Text != "")
            {
                connectingButton.IsEnabled = true;
            }
            else
            {
                connectingButton.IsEnabled = false;
            }
        }
        #endregion

       
    }
}
