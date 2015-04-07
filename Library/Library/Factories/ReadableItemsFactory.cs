namespace Library
{
    using System;

    public class ReadableItemsFactory : IReadableItemsFactory
    {
        //TODO!!!
        //Constructors with Comments

        public IReadable CreateReadableItem(string[] data)
        {
            string itemType = data[0];
            string name = data[1];
            string publisher = data[2];
            int year = int.Parse(data[3]);
            Genres genre = GetGenre(data[4]);
            string authorOrIssue = data[5];
            int counter = int.Parse(data[6]);
            int totalRatings = int.Parse(data[7]);
            int averageRating = int.Parse(data[8]);

            Rating rating = new Rating(counter, totalRatings, averageRating);

            switch (itemType)
            {
                case "Book":
                    return new Book(name, publisher, year, genre, rating, authorOrIssue);
                case "Magazine":
                    return new Magazine(name, publisher, year, genre, rating, authorOrIssue);
                case "Newspaper":
                    return new Newspaper(name, publisher, year, genre, rating, authorOrIssue);
                default: throw new ArgumentException("You must specify what kind of readable item you want to create!");
            }
        }

        private static Genres GetGenre(string genre)
        {
            switch (genre)
            {
                case "Business":
                    return Genres.Business;
                case "Hobby":
                    return Genres.Hobby;
                case "Lifestyle":
                    return Genres.Lifestyle;
                case "Entrepreneurship":
                    return Genres.Entrepreneurship;
                case "MainstreamMedia":
                    return Genres.MainstreamMedia;
                case "Autobiography":
                    return Genres.Autobiography;
                case "TextBook":
                    return Genres.TextBook;
                case "Programming":
                    return Genres.Programming;
                case "Adults":
                    return Genres.Adults;
                case "ManMadeMarvels":
                    return Genres.MainstreamMedia;
                default:
                    throw new LibraryItemException(LibraryItemException.InvalidGenreException);
            }
        }
    }
}
