namespace TeamVaxxers
{
    public class User
    {
        public string Password { get; set; }
        public string UserName { get; set; }
        
        public int level { get; set; }
        public long Time { get; set; }

        public int changePassword(string old, string newP)
        {
            if(old==Password)
            {
                Password = newP;
                return 1;

            }
            else
            {
                return -1;

            }
            
        }
    }
    internal class Users
    {
        public int Total { get; set; }
        public User[] data { get; set; }

        public int validate(string name, string psw)
        {
            foreach(var user1 in this.data)
            {
                if (user1.UserName == name && user1.Password == psw)
                {
                    return 1;
                }

            }

            return -1;

        }
        public void listUsers()
        {


        }

    }
}
