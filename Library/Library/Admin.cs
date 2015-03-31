namespace Library
{
    public class Admin : Profile, IAdmin
    {
        private ProfileType profileType;

        public Admin(string name, string password) 
            :base(name, password)
        {
            this.ProfileType = ProfileType.Administrator;
        }

        public ProfileType ProfileType
        {
            get { return this.profileType; }
            set { this.profileType = value; }
        }

        public void AddReadableItem(IReadable readable)
        {
            throw new System.NotImplementedException();
        }        
    }
}
