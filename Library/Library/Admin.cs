namespace Library
{
    public class Admin: Profile
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

        public void AddBook(string name, string author, Genres genre)
        {
            Book book = new Book();
            book.Author = author;
            book.Name = name;
        }
    }
}
