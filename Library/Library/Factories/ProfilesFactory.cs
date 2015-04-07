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
                case "administrator":
                    var profileAdmin = new Admin(name, password);
                    Library.Instance.dataManager.SerializeProfiles(profileAdmin);
                    return profileAdmin;
                case "moderator":
                    var profileMod = new Moderator(name, password);
                    Library.Instance.dataManager.SerializeProfiles(profileMod);
                    return profileMod;
                case "regularuser":
                    var profileUser = new Moderator(name, password);
                    Library.Instance.dataManager.SerializeProfiles(profileUser);
                    return profileUser;
                default:
                    throw new ArgumentException("You must specify a profile type!");
            }
        }
    }
}
