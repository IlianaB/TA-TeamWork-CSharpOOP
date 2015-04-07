namespace Library
{
    using System;
    using System.Collections.Generic;

    class Start
    {
        static void Main()
        {
            Library.Instance.Start();

            Console.WriteLine();

            //string[] test = { "moderator", "Mihail", "parolkata" };
            //var profile = Library.Instance.profilesFactory.CreateProfile(test);
            //Library.Instance.SaveProfile(profile);
            //Library.Instance.AddUser(profile);

            //Console.WriteLine(profile);

            //string[] test2 = { "Newspaper", "24 chasa", "New Media", "2015", "MainstreamMedia", "2", "4", "2", "12" };
            //var readable = Library.Instance.readableItemsFactory.CreateReadableItem(test2);
            //Library.Instance.SaveReadableItem(readable);
            //Library.Instance.AddReadableItem(readable);

            //Console.WriteLine(readable);
        }
    }
}
