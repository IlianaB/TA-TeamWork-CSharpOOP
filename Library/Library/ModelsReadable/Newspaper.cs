namespace Library
{
    public class Newspaper : ReadableItem
    {
        private string issue;

        public Newspaper(string name, string publisher, int year, Genres genre, Rating rating, string issue)
            : base(name, publisher, year, genre, rating)
        {
            this.Issue = issue;        
        }

        public string Issue
        {
            get { return this.issue; }
            private set { this.issue = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("|{0}", this.issue);
        }
    }
}
