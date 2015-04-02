namespace Library
{
    using System;
    using System.Collections.Generic;

    public interface IUser : IProfile
    {
        IEnumerable<IReadable> ReadItems { get; set; }
        IEnumerable<IReadable> CurrentlyReadItems { get; set; }
        IEnumerable<IReadable> WishedToReadItems { get; set; }

        void AddToCurrentReadable(IReadable readable);

        void AddToWishedReadable(IReadable readable);

        void RemoveCurrentReadable(IReadable readable);

        void RemoveWishedReadable(IReadable readable);

        void FinishReadable(IReadable readable);
    }
}
