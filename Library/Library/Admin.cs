namespace Library
{
    public class Admin: User
    {
        private bool hasAdminRights;

        public bool HasAdminRights { get; set; }

        public void AddBook(string name, string author, GenresEnum genre)
        {
            Books book = new Books();
            book.Author = author;
            book.Name = name;
            book.Genre = genre.ToString();
        }


    }
}
