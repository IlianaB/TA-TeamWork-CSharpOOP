namespace Library
{
    using System;
    using System.Collections.Generic;

    public sealed class Library
    {
        private const string ExceptionMessageIfReadableItemIsAlreadyInTheLibrary = "This item is already in this database!";
        private const string ExceptionMessageIfReadableItemIsNotInTheLibrary = "This item is not in this database!";
        private const string ExceptionMessageIfUserIsAlreadyInTheLibrary = "This user is already in this database!";

        //Creating single instance
        private static readonly Library SingleInstance = new Library("Online library");

        private string name;
        private ICollection<IReadable> readableItems;
        private ICollection<IProfile> users;  

        public Library(string name)
        {
            this.Name = name;
            this.readableItems = new List<IReadable>();
            this.users = new List<IProfile>();
        }

        public static Library Instance
        {
            get
            {
                return SingleInstance;
            }
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

        public ICollection<IReadable> ReadableItems
        {
            get
            {
                return new List<IReadable>(this.readableItems);
            }
        }

        public ICollection<IProfile> Users
        {
            get
            {
                return new List<IProfile>(this.users);
            }
        }

        public void AddReadableItem(IReadable readable)
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

        public void RemoveReadableItem(IReadable readable)
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

        public void AddUser(IProfile user)
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

         public void InitializeReadableItems()
         {
             //Receive string array from file manager
             //Return arraywith objects
         }

         public void InitializeProfiles()
         { 
             //Receive string array from file manager
             //Return array with oobjects
         }

         public void Start()
         {
             ProfilesFactory profilesFactory = new ProfilesFactory();
             ReadableItemsFactory readableItemsFactory = new ReadableItemsFactory();
             Search search = new Search();
             this.InitializeProfiles();
             this.InitializeReadableItems();

             //var currentUser = new Profile(name, password, profileType);
         }
    }
}