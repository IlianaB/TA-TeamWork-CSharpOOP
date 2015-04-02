namespace Library
{
    using System;
    using System.Collections.Generic;

    public abstract class User : Profile, IUser
    {
        public IEnumerable<IReadable> ReadItems { get; set; }
        public IEnumerable<IReadable> CurrentlyReadItems { get; set; }
        public IEnumerable<IReadable> WishedToReadItems { get; set; }

        public User(string name, string password) 
            :base(name, password)
        {
            this.ReadItems = new List<IReadable>();
            this.CurrentlyReadItems = new List<IReadable>();
            this.WishedToReadItems = new List<IReadable>();
        }


    }
}
