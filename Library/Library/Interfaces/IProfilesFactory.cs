namespace Library
{
    public interface IProfilesFactory
    {
        IProfile CreateProfile(string profileType, string name, string password);
    }
}
