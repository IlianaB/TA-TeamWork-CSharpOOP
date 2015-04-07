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

        public readonly ProfilesFactory profilesFactory;
        public readonly ReadableItemsFactory readableItemsFactory;
        public readonly Search search;
        public readonly DataManager dataManager;

        public Library(string name)
        {
            this.Name = name;
            this.readableItems = new List<IReadable>();
            this.users = new List<IProfile>();
            this.profilesFactory = new ProfilesFactory();
            this.readableItemsFactory = new ReadableItemsFactory();
            this.search = new Search();
            this.dataManager = new DataManager();
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

        public void Start()
        {
            this.InitializeProfiles();
            this.InitializeReadableItems();

            //var currentUser = new Profile(name, password, profileType);
        }

        public void InitializeReadableItems()
        {
            var allReadables = dataManager.ReadReadables();

            foreach (var line in allReadables)
            {
                string[] data = new string[9];
                data = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var readableItem = readableItemsFactory.CreateReadableItem(data);
                this.AddReadableItem(readableItem);
            }
        }

        public void InitializeProfiles()
        {
            var allProfiles = dataManager.ReadProfiles();

            foreach (var line in allProfiles)
            {
                string[] data = new string[3];
                data = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var profile = profilesFactory.CreateProfile(data);
                this.AddUser(profile);
            }
        }

        public bool isAlreadyInTheLibrary(IProfile profile)
        {
            foreach (var profileItem in Library.Instance.Users)
            {
                if (profile.Name == profileItem.Name)
                {
                    return true;
                }
            }

            return false;
        }

        public bool isAlreadyInTheLibrary(IReadable readableItem)
        {
            foreach (var readable in Library.Instance.ReadableItems)
            {
                if (readable.Name == readableItem.Name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}