using Newtonsoft.Json.Linq;
using SARSDemoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace SARSDemoApp.View
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        
        public LoginPage()
        {
            InitializeComponent();

           

         }
        public void login()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/");

            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            bool isLoggedIn = false;

            Login login = new Login();
            login.username = username.Text;
            login.password = password.Password.ToString();

            var userToCheck = username.Text;
            var url = "http://127.0.0.1:5000/auth/login/" + userToCheck;

            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var registered_user = response.Content.ReadAsStringAsync().Result;
                


                if (registered_user != null)
                {
                    JArray jsonArray = JArray.Parse(registered_user);

                    if (jsonArray[2].ToString() == login.password)
                          {
                                isLoggedIn = true;
                                //MessageBox.Show("succesfully loggedin!");
                                //pass the user id to th profile page and display user details
                       }
                      else
                      {
                        
                        MessageBox.Show("password is invalid!");
                        
                      }


                }
               

            }
            else
            {
                MessageBox.Show("User with specified details does not exit. Go to Register!");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login();
        }
    }
}
