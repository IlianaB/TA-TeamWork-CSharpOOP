namespace Library
{
    public class Books : TakeAway
    {
        private string author;
        private string genre;
        private string name;

        public Books()
        { 
        
        }

        public string  Author { get; set; }
        public string  Genre { get; set; }
        public string  Name { get; set; }
    }
}
