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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        public void register()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/");

            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            // string username = username;
            // string url = "http://127.0.0.1:5000/user/" + user_id;


            User user = new User();

            user.full_name = fullname.Text;
            user.email = email.Text;
            user.company = company.Text;
            user.position = position.Text;
            user.south_african_id = sa_id.Text;

            Register register = new Register();
            register.username = username.Text;
            register.password = password.Password.ToString();

            var userToCheck = username.Text;
            var url = "http://127.0.0.1:5000/auth/user/" + userToCheck;

            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var registered_user = response.Content.ReadAsStringAsync().Result;

                if (registered_user != null)
                {

                    username.Text = "User with specified username exists, login/Use a different username";
                    username.Foreground = new SolidColorBrush(Colors.Red);

                }
                else
                {

                }

            }
            else
            {
                var res = client.PostAsJsonAsync("http://127.0.0.1:5000/users", user).Result;
                var newuser = res.Content.ReadAsStringAsync().Result;
                res.EnsureSuccessStatusCode();

                var register_response = client.PostAsJsonAsync("http://127.0.0.1:5000/auth/register", register).Result;
                var newly_registered_user = register_response.Content.ReadAsStringAsync().Result;
                register_response.EnsureSuccessStatusCode();

                MessageBox.Show("You were Successfully Register !");
                fullname.Text="";
                email.Text="";
                username.Text="";
                password.Password="";
                position.Text="";
                sa_id.Text="";

                LoginPage loginPage = new LoginPage();


                NavigationService.Navigate(loginPage);
            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            register();
        }
    }
   
}
