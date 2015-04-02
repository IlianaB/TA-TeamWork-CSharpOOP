namespace Library
{

    public class Admin : Profile, IAdmin
    {
        public Admin(string name, string password) 
            :base(name, password, ProfileType.Administrator)
        {
        }

        public void AddReadableItem(IReadable readable)
        {
            throw new System.NotImplementedException();
        }        

        public void RemoveReadableItem(IReadable readable)
        {
            throw new System.NotImplementedException();
        }
    }
}
