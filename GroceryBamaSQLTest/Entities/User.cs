using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace GroceryBama.Entities
{
    [DataContract]
    public class User
    {
        public string Username { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Role { get; set; }

        public string Token { get; set; }
    }

    public class UserCredential
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
