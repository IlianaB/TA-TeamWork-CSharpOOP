namespace Library
{
    public struct Rating
    {
        public int Counter { get; private set; }
        public int TotalRatings { get; private set; }

        public double AverageRating
        {
            get
            {
                return (double)this.TotalRatings / this.Counter;
            }
        }

        public void ChangeRating(int userRating)
        {
            this.IncreaseCounter();
            this.IncreaseTotalRatings(userRating);
        }

        private void IncreaseCounter()
        {
            this.Counter++;
        }

        private void IncreaseTotalRatings(int userRating)
        {
            this.TotalRatings += userRating;
        }
    }
}
