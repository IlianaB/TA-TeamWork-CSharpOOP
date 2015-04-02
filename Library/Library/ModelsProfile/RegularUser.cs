using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RegularUser : User //IRegularUser
    {
        public RegularUser(string name, string password) 
            : base(name, password)
        {

        }
    }
}
