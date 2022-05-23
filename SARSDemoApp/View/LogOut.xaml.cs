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
using SARSDemoApp.Model;
using SARSDemoApp.Global;

namespace SARSDemoApp.View
{
    /// <summary>
    /// Interaction logic for LogOut.xaml
    /// </summary>
    public partial class LogOut : Page
    {
        public LogOut()
        {
            InitializeComponent();

            
        }
         
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            global.UserID = 0;
            LoginPage loginPage = new LoginPage();


            NavigationService.Navigate(loginPage);
        }
    }
}
