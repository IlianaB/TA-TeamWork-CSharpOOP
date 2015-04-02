﻿namespace Library
{
    public class RegularUser : User, IRegularUser
    {
        public RegularUser(string name, string password) 
            : base(name, password, ProfileType.RegularUser)
        {
        }
    }
}
