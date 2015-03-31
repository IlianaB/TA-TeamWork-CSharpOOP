namespace Library
{
    using System;

    public abstract class TakeAway : ReadableItem
    {
        public DateTime DateRented { get; protected set; }
        public DateTime DateReturned { get; protected set; }
        public int TotalDaysKeptItem { get; set; }

    }
}
