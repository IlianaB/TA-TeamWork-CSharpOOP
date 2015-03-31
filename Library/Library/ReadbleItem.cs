namespace Library
{
    public abstract class ReadbleItem
    {
        private string name;
        private string publisher;
        private int year;

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
