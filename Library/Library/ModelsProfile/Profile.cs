namespace Library
{
    using System;

    public abstract class Profile : IProfile
    {
        private string name;
        private string password;
        private ProfileType profileType;

        public Profile(string name, string password, ProfileType profileType)
        {
            this.Name = name;
            this.Password = password;
            this.ProfileType = profileType;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Password
        {
            set { this.password = value; }
        }

        public ProfileType ProfileType
        {
            get { return this.profileType; }
            private set { this.profileType = value; }
        }
    }
}
