using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Moderator : User, IModerator
    {
        public void RemoveComment()
        {
            throw new NotImplementedException();
        }
        
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
