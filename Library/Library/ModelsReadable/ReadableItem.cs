namespace Library
{
    using System.Collections.Generic;

    public abstract class ReadableItem : IReadable
    {
        private string name;
        private string publisher;
        private int year;
        private Rating rating;
        private Genres genre;
        private IEnumerable<Comment> comment;

        public ReadableItem(string name, string publisher, int year, Genres genre)
        {
            this.Name = name;
            this.Publisher = publisher;
            this.Year = year;
            this.Genre = genre;
            this.comment = new List<Comment>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public Genres Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }

        public IEnumerable<Comment> Comment
        {
            get 
            { 
                return new List<Comment>(this.comment); 
            }            
        }

        //TODO
        public abstract string DisplaReadableInformation();
        
    }
}
