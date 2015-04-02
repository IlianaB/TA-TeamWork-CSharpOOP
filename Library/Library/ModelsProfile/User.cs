namespace Library
{
    using System;
    using System.Collections.Generic;

    public abstract class User : Profile, IUser
    {
        public ICollection<IReadable> ReadItems { get; set; }
        public ICollection<IReadable> CurrentlyReadItems { get; set; }
        public ICollection<IReadable> WishedToReadItems { get; set; }

        public User(string name, string password, ProfileType profileType) 
            :base(name, password, profileType)
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

        IEnumerable<IReadable> IUser.ReadItems
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        IEnumerable<IReadable> IUser.CurrentlyReadItems
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        IEnumerable<IReadable> IUser.WishedToReadItems
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public void AddToCurrentReadable(IReadable readable)
        {
            throw new NotImplementedException();
        }

        public void AddToWishedReadable(IReadable readable)
        {
            throw new NotImplementedException();
        }

        public void RemoveCurrentReadable(IReadable readable)
        {
            throw new NotImplementedException();
        }

        public void RemoveWishedReadable(IReadable readable)
        {
            throw new NotImplementedException();
        }

        public void FinishReadable(IReadable readable)
        {
            throw new NotImplementedException();
        }
    }
}
