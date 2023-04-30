using System;
using System.Collections.Generic;
namespace TeamVaxxers
{
    public class User
    {
        public string Password { get; set; }
        public string UserName { get; set; }
        
        public int level { get; set; }
        

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
    public class Users
    {
        public int Total { get; set; }
        public List<User> data { get; set; }

        public int validate(string name, string psw)
        {
            foreach(var user1 in this.data)
            {
                if (user1.UserName == name && user1.Password == psw)
                {
                    if (user1.level == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }

            }

            return -1;

        }
        public int addUser(string name, string psw)
        {
            foreach (var user1 in this.data)
            {
                if (user1.UserName == name)
                {
                    return -1;
                }
                

            }
            Total++;
            User temp = new User();
            temp.UserName = name;
            temp.level = 0;
            temp.Password = psw;
            data.Add(temp);
            return 0;
        }
        public int removeUser(string name)
        {
            int i = 0;
            foreach (var user1 in this.data)
            { 
                i++;
                if( user1.level==1 && user1.UserName == name)
                {
                    return -2;//cant delte administrator
                }
                if (user1.UserName == name)
                {
                    this.data.Remove(user1);
                    this.Total--;
                    return 0;
                }
                


            }
            return -1;
            

        }


    }
}
