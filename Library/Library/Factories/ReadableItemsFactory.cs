namespace Library
{
    using System;

    public class ReadableItemsFactory : IReadableItemsFactory
    {
        //TODO!!!
        //Constructors with Comments

        public IReadable CreateReadableItem(string itemType, string name, string publisher, int year, string stringGenre, 
                                            string authorOrIssue, int counter = 0, int totalRatings = 0, int averageRating = 0)
        {
            Genres genre = GetGenre(stringGenre);
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
                case "Prgramming":
                    return Genres.Prgramming;
                case "Animals":
                    return Genres.Animals;
                case "ManMadeMarvels":
                    return Genres.MainstreamMedia;
                default:
                    //TODO!!!
                    //throw custom Exception
                    throw new ArgumentException();
            }
        }
    }
}
