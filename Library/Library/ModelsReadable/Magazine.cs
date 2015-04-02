namespace Library
{
    public class Magazine : ReadableItem
    {
        private string issue;

        public Magazine(string name, string publisher, int year, Genres genre, string issue)
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
