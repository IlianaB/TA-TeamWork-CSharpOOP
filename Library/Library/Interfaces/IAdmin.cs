namespace Library
{
    using System;

    public interface IAdmin : IProfile
    {
        void SendToLibrary(IReadable readable);

        void RemoveFromLibrary(IReadable readable);
    }
}
