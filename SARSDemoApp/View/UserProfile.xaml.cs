using Newtonsoft.Json.Linq;
using SARSDemoApp.Model;
using SARSDemoApp.ViewModel;
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
using SARSDemoApp.Global;

namespace SARSDemoApp.View
{
    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Page
    {
        int _userId;
        

        public UserProfile(int userId)
        {

            InitializeComponent();
            _userId = userId;

            //Fullname.Text = "Edwin Motlokwa";

            userdata(_userId);
            
        }
        public UserProfile()
        {
            var id = global.UserID;
            InitializeComponent();


            //Fullname.Text = "Edwin Motlokwa";

            userdata(id);
            
        }
       


        public  void userdata( int userId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/users");
           
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            //var userId = 1;
            var url = "http://127.0.0.1:5000/user/" + userId;

            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                var user = response.Content.ReadAsStringAsync().Result;
                JArray jsonArray = JArray.Parse(user);

                if (user != null)
                {
                  
                    Fullname.Text = jsonArray[1].ToString();
                    Email.Text = jsonArray[2].ToString();
                    Company.Text = jsonArray[3].ToString();
                    Position.Text = jsonArray[4].ToString();
                    Id.Text= jsonArray[5].ToString();

                    Status.Text = "Compliant";
                    Date.Text = DateTime.Now.ToString();

                    bool log = IsLoggedIn.isloggedin;
                }
                

            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Succesfully Submitted");
        }
        //

    }
    
}
