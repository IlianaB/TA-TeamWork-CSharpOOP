namespace Library
{
    public static class ProfilesFactory
    {
        public static IAdmin CreateAdmin(string name, string password)
        {
            return new Admin(name, password);
        }

        public static IModerator CreateModerator(string name, string password)
        {
            return new Moderator(name, password);
        }

        public static IRegularUser CreateRegularUser(string name, string password)
        {
           return new RegularUser(name, password);
        }
    }
}
