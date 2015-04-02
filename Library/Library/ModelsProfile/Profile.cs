namespace Library
{
    using System;

    public abstract class Profile : IProfile
    {
        private string name;
        private string password;

        public Profile(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Password
        {
            set { this.password = value; }
        }        
    }
}
