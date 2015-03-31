namespace Library
{
    using System;

    public interface IAdmin : IProfile
    {
        void AddReadableItem(IReadable readable);
    }
}
