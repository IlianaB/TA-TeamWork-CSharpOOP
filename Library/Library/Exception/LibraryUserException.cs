

namespace Library.Exception
{
    using System;
   public class LibraryUserException:ApplicationException
    {
       
        public const string InvalidPasswordException = "Password must be at least 6 symbols!";
        public const string InvalidUsernameException = "Username must be at least 8 symbols!";
        public const string ExistingUserException = "User already exists in the library!";


        public LibraryUserException(string message)
            : base(message)
        {
        }
    }
}
