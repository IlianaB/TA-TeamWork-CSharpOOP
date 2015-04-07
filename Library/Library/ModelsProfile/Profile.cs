namespace Library
{
    using System;

    public abstract class Profile : IProfile
    {
        private const int MinName = 2;
        private const int MaxName = 15;

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
            private set 
            {
                LibraryUserException.CheckIfNameIsNullOrEmpty(name, LibraryUserException.NullNameException);
                LibraryUserException.CheckIfNameLengthIsValid(name, MinName, MaxName, LibraryUserException.NameLEngthExceptionMsg);
                this.name = value; 
            }
        }

        public string Password
        {
            set 
            {
                LibraryUserException.CheckPasswordLength(password, LibraryUserException.InvalidPasswordException);
                this.password = value; 
            }
        }

        public ProfileType ProfileType
        {
            get { return this.profileType; }
            private set { this.profileType = value; }
        }
    }
}
