namespace Library
{
    using System;
    using System.Collections.Generic;

    public static class Search
    {
        private const string ExceptionMessageForKeywordsLength = "Keyword cannot be less than 3 symbols";

        public static ICollection<IReadable> SearchReadableItem(string keyword)
        {
            if (keyword.Length < 3)
            {
                throw new ArgumentOutOfRangeException(ExceptionMessageForKeywordsLength);
            }

            var searchResult = new List<IReadable>();

            foreach (var readable in Library.Instance.ReadableItems)
            {
                if (readable.Name == keyword)
                {
                    searchResult.Add(readable);
                }
            }

            return searchResult;

        }
    }
}
