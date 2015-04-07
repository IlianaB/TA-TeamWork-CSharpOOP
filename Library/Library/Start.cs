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
            //Console.WriteLine();
        }
    }
}
