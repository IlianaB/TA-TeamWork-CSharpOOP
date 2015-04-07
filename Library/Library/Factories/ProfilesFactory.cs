namespace Library
{
    using System;
    using System.Collections.Generic;

    public class ProfilesFactory : IProfilesFactory
    {
        public IProfile CreateProfile(string[] data)
        {
            string profileType = data[0];
            string name = data[1];
            string password = data[2];

            switch (profileType)
            {
                case "Admin":
                    return new Admin(name, password);
                case "Moderator":
                    return new Moderator(name, password);
                case "RegularUser":
                    return new RegularUser(name, password);
                default:
                    throw new ArgumentException("You must specify a profile type!");
            }
        }
    }
}
