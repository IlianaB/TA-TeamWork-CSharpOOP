namespace Library
{
    public class Book : ReadableItem
    {
        private string author;

        public Book(string name, string publisher, int year, Genres genre, string author) 
            : base(name, publisher, year, genre)
        {
            this.Author = author;
        }   

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        } 
    }
}
