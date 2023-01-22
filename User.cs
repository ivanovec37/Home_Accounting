using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Accounting
{
    [Serializable]

    public class User 
    {
       
        public string Login { get; set; }
        
        public string Password { get; set; }

        public Guid Id  { get; set; } = Guid.NewGuid();
        
        public User( string login, string password)
        {
           
            Login = login;
            Password = password;

        }


       
    }

}
