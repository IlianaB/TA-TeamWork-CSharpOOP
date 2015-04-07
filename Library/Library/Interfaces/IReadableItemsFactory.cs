namespace Library
{
    public interface IReadableItemsFactory
    {
        IReadable CreateReadableItem(string[] data);
    }
}
