namespace Library
{
    using System;

    public interface IUser : IProfile
    {
        string CurrentReadBook { get; set; }
        string ReadBook { get; set; }
        string WishedBook { get; set; }
    }
}
