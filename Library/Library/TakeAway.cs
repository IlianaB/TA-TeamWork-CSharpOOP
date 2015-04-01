namespace Library
{
    using System;

    public abstract class TakeAway : ReadableItem
    {
        public DateTime DateRented { get; protected set; }
        public DateTime DateReturned { get; protected set; }
        public int TotalDaysKeptItem { get; set; }

        public TakeAway(string name, string publisher, int year) 
            :base(name, publisher, year)
        {
        }

    }
}
