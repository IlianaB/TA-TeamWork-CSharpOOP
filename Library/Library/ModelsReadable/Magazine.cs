namespace Library
{
    public class Magazine : ReadableItem
    {
        private string issue;

        public Magazine(string name, string publisher, int year, Genres genre, Rating rating, string issue)
            : base(name, publisher, year, genre, rating)
        {
            this.Issue = issue;        
        }

        public string Issue
        {
            get { return this.issue; }
            private set { this.issue = value; }
        }
    }
}
