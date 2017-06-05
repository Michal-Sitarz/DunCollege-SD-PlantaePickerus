using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantaePickerus_proto
{
    class User
    {
        private string username;

        public User()
        {
            
        }

        //set
        public void setUsername(string _username)
        {
            this.username = _username;
        }

        //get
        public string getUsername()
        {
            return this.username;
        }
    }
}
