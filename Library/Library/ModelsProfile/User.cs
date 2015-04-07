namespace Library
{
    using System;
    using System.Collections.Generic;

    public abstract class User : Profile, IUser
    {
        public ICollection<IReadable> readItems;
        public ICollection<IReadable> currentlyReadItems;
        public ICollection<IReadable> wishedToReadItems; 

        public User(string name, string password, ProfileType profileType) 
            :base(name, password, profileType)
        {
            this.readItems = new List<IReadable>();
            this.currentlyReadItems = new List<IReadable>();
            this.wishedToReadItems = new List<IReadable>();
        }
        // Properties
        public ICollection<IReadable> ReadItems
        {
            get
            {
                return new List<IReadable>(readItems);
            }            
        }

        public ICollection<IReadable> CurrentlyReadItemset
        {
            get
            {
                return new List<IReadable>(currentlyReadItems);
            }
        }

        public ICollection<IReadable> WishedToReadItems
        {
            get
            {
                return new List<IReadable>(wishedToReadItems);
            }
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
