namespace Library
{
    public interface IReadableItemsFactory
    {
        IReadable CreateReadableItem(string itemType, string name, string publisher, int year, string stringGenre,
                                     string authorOrIssue, int counter = 0, int totalRatings = 0, int averageRating = 0);
    }
}
