namespace Library
{
    public abstract class ReadableItem : IReadable
    {
        private string name;
        private string publisher;
        private int year;

        public ReadableItem(string name, string publisher, int year)
        {
            this.Name = name;
            this.Publisher = publisher;
            this.Year = year;
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

    }
}
