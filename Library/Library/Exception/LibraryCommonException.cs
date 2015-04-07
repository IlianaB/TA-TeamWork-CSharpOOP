namespace Library
{
    using System;

    public class LibraryCommonException : ApplicationException
    {
        public const string ExceptionMessageForKeywordsLength = "Keyword cannot be less than 3 symbols";
        public const string ExceptionMessageForRatingPoints = "Rating points must be between 1 and 5";

        public LibraryCommonException(string message)
            : base(message)
        {
        }        
    }
}
