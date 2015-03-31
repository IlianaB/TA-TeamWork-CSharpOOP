namespace Library
{
    public class Newspaper: ReadOnSpot
    {
        private string issue;

        public Newspaper()
        { 
        
        }

        public string Issue
        {
            get { return this.issue; }
            set { this.issue = value; }
        }
    }
}
