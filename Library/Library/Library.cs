namespace Library
{
    using System;
    using System.Collections.Generic;

    public abstract class Library
    {
        private const string ExceptionMessageIfReadableItemIsAlreadyInTheLibrary = "This item is already in this database!";
        private const string ExceptionMessageIfReadableItemIsNotInTheLibrary = "This item is not in this database!";
        private const string ExceptionMessageIfUserIsAlreadyInTheLibrary = "This user is already in this database!";

        // Lets try using HashSet because we can keep only unique elements
        private string name;
        private HashSet<ReadableItem> readableItems;
        private HashSet<User> users;  // dont know what to use User or Profile

        public Library(string name)
        {
            this.Name = name;
            this.readableItems = new HashSet<ReadableItem>();
            this.users = new HashSet<User>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                // TODO: add some validation check and exceptions
                this.name = value;
            }
        }

        private HashSet<ReadableItem> ReadableItems
        {
            get
            {
                return new HashSet<ReadableItem>(this.readableItems);
            }
        }

        private HashSet<User> Users
        {
            get
            {
                return new HashSet<User>(this.users);
            }
        }

        public void AddReadableItem(ReadableItem readable)
        {
            if (this.readableItems.Contains(readable))
            {
                throw new ArgumentException(ExceptionMessageIfReadableItemIsAlreadyInTheLibrary);
            }

            else
            {
                this.readableItems.Add(readable);
            }
        }

        public void RemoveReadableItem(ReadableItem readable)
        {
            if (!this.readableItems.Contains(readable))
            {
                throw new ArgumentException(ExceptionMessageIfReadableItemIsNotInTheLibrary);
            }

            else
            {
                this.readableItems.Remove(readable);
            }
        }

        public void AddUser(User user)
        {
            if (this.users.Contains(user))
            {
                throw new ArgumentException(ExceptionMessageIfUserIsAlreadyInTheLibrary);
            }

            else
            {
                this.users.Add(user);
            }
        }
    }
}