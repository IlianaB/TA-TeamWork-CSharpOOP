namespace Library
{
    using System;

    public interface IRegularUser : IUser
    {
        void AddToCurrentReadable(IReadable readable);

        void AddToWishedReadable(IReadable readable);

        void RemoveCurrentReadable(IReadable readable);

        void RemoveWishedReadable(IReadable readable);

        void FinishReadable(IReadable readable);


    }
}
