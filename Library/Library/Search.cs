namespace Library
{
    using System;
    using System.Collections.Generic;

    public abstract class Search
    {
        private const string ExceptionMessageForKeywordsLength = "Keywords be less than 3 symbols";

        public HashSet<ReadableItem> SearchReadableItem(string keywords)
        {
            if (keywords.Length < 3)
            {
                throw new ArgumentOutOfRangeException(ExceptionMessageForKeywordsLength);
            }
            var resultForSearch = new HashSet<ReadableItem>();

            // TODO: find a way to get the collection from class Library
            //foreach (var readable in [collection])
            //{
            //    resultForSearch.Add(readable);
            //}
            return resultForSearch;

        }
    }
}
