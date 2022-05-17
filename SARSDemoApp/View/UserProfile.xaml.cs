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

namespace SARSDemoApp.View
{
    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : UserControl
    {
       

        public UserProfile()
        {

            InitializeComponent();
            

            //Fullname.Text = "Edwin Motlokwa";

            userdata();
            
           
        }

        public  void userdata()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/users");
           
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("http://127.0.0.1:5000/users").Result;
            if (response.IsSuccessStatusCode)
            {
                var users = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                
                if(users != null)
                {
                    Fullname.Text = users.FirstOrDefault().full_name.ToString();
                    Email.Text = users.FirstOrDefault().email.ToString();
                    Company.Text = users.FirstOrDefault().company.ToString();
                    Position.Text = users.FirstOrDefault().position.ToString();
                    Id.Text=users.FirstOrDefault().south_african_id.ToString();

                    Status.Text = "Compliant";
                    Date.Text = DateTime.Now.ToString();
                }
               

            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
        //
       
    }
    
}
