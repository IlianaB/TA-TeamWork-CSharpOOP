namespace Library
{
    public class Book //: TakeAway
    {
        private string author;
        private Genres genre;

        public Book()
        {

        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public Genres Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }



    }
}
