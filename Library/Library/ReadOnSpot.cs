namespace Library
{
    using System;

    public abstract class ReadOnSpot : ReadableItem
    {
        public DateTime CurrentDate { get; set; }
        public bool TakenItemsFromLibrary { get; set; }
        public int NumberOfItemsTaken { get; set; }
        

    }
}
