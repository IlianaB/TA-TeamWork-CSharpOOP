namespace Library
{

    public class Admin : Profile, IAdmin
    {
        public Admin(string name, string password) 
            :base(name, password, ProfileType.Administrator)
        {
        }

        public void SendToLibrary(IReadable readable)
        {
            Library.Instance.SaveReadableItem(readable);
            Library.Instance.AddReadableItem(readable);
        }

        public void RemoveFromLibrary(IReadable readable)
        {
            throw new System.NotImplementedException();
        }
    }
}
