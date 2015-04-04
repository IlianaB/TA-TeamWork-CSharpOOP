namespace Library
{
    using System;

    public static class ReadableItemsFactory
    {
        //TODO!!!
        //Constructors with Comments
        //Working with interfaces as return types, when they are added

        public static Book CreateBook(string name, string publisher, int year, string stringGenre, string author)
        {
            Genres genre = GetGenre(stringGenre);
            Rating rating = new Rating();

            return new Book(name, publisher, year, genre, rating, author);
        }

        public static Magazine CreateMagazine(string name, string publisher, int year, string stringGenre, string issue)
        {
            Genres genre = GetGenre(stringGenre);
            Rating rating = new Rating();

            return new Magazine(name, publisher, year, genre, rating, issue);
        }

        public static Newspaper CreateNewspaper(string name, string publisher, int year, string stringGenre, string issue)
        {
            Genres genre = GetGenre(stringGenre);
            Rating rating = new Rating();

            return new Newspaper(name, publisher, year, genre, rating, issue);
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
