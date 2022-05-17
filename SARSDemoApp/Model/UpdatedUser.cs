using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARSDemoApp.Model
{
    public class UpdatedUser
    {
        public int user_id { get; set; }    
        
        public string full_name { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public string position { get; set; }
        public string south_african_id { get; set; }
    }
}
