using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RegularUser : User, IRegularUser
    {
        
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public string Password
        {
            set { throw new NotImplementedException(); }
        }

        
    }
}
