namespace Library
{
    using System;

    class User
    {
        private string userID;

        public string  UserID 
        { 
            get
            {
                if (userID.Length < 2)
	            {
	            	throw new ArgumentException("Please enter an ID longer than 2 chars")
	            }
                return this.userID;
            }
                
            set; 
        
        
        }
    }
}
