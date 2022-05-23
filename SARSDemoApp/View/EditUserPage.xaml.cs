using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SARSDemoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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
    /// Interaction logic for EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        //int _userId;
        

        //public  EditUserPage(int userId)
        //{
        //    InitializeComponent();
        //    _userId = userId;

        //    loadUser(_userId);
        //}
        public EditUserPage()
        {
            var id = global.UserID;
            InitializeComponent();

            loadUser(id);
        }
        
        public void loadUser(int user_id)
        {

            global.UserID = user_id;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/users");

            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

           // int user_id = 1;
            var url = "http://127.0.0.1:5000/user/" + user_id;
           

            HttpResponseMessage response =  client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {

               
                 var user = response.Content.ReadAsStringAsync().Result;

               
                JArray jsonArray = JArray.Parse(user);
                


                if(jsonArray != null)
                {
                    fullname.Text = jsonArray[1].ToString();
                    email.Text = jsonArray[2].ToString();
                    company.Text = jsonArray[3].ToString();
                    position.Text = jsonArray[4].ToString();
                    sa_id.Text = jsonArray[5].ToString();
                    
                    
                   
                }

                

            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
            
        }

        private  void Update_User(object sender, RoutedEventArgs e)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:5000/");

            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            int user_id = 1;
              string url = "http://127.0.0.1:5000/user/" + user_id;
         

            UpdatedUser updatedUser = new UpdatedUser();
            updatedUser.user_id = user_id;
            updatedUser.full_name = fullname.Text;
            updatedUser.email = email.Text; 
            updatedUser.company = company.Text;
            updatedUser.position = position.Text;
            updatedUser.south_african_id = sa_id.Text;

         
    
            var response = client.PutAsJsonAsync("/user/1", updatedUser).Result;


            var user = response.Content.ReadAsStringAsync().Result;

             response.EnsureSuccessStatusCode();

            

            MessageBox.Show("User updated");
            fullname.Text = "";
            email.Text = "";
            company.Text = "";
            position.Text = "";
            sa_id.Text="";

        }
    }

    
}
