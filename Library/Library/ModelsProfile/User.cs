namespace Library
{
    using System;
    using System.Collections.Generic;

    public abstract class User : Profile, IUser
    {

        public ICollection<IReadable> ReadItems { get; set; }
        public ICollection<IReadable> CurrentlyReadItems { get; set; }
        public ICollection<IReadable> WishedToReadItems { get; set; }

        public User(string name, string password) 
            :base(name, password)
        {
            this.ReadItems = new List<IReadable>();
            this.CurrentlyReadItems = new List<IReadable>();
            this.WishedToReadItems = new List<IReadable>();
        }

        public void AddReadItem(ReadableItem readableItem)
        {
            if (this.ReadItems.Contains(readableItem))
            {
                throw new ArgumentException();
            }
            else
            {
                this.ReadItems.Add(readableItem);
            }            
        }
    }
}
