namespace Library
{
    using System;

    public class ProfilesFactory : IProfilesFactory
    {
        public IProfile CreateProfile(string profileType, string name, string password)
        {
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
