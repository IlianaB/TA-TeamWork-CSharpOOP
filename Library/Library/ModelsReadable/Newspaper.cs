namespace Library
{
    public class Newspaper : ReadableItem
    {
        private string issue;

        public Newspaper(string name, string publisher, int year, Genres genre, string issue)
            : base(name, publisher, year, genre)
        {
            this.Issue = issue;        
        }

        public string Issue
        {
            get { return this.issue; }
            set { this.issue = value; }
        }
    }
}
