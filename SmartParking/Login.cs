using System;
using System.Windows.Forms;

using Firebase.Database;
using Firebase.Database.Query;
namespace TeamVaxxers
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void getUserDataAsync(string name, string pws) // grabs population from database 
        {
            FirebaseClient client = new FirebaseClient("https://parking-lot-f206b-default-rtdb.firebaseio.com");
            Users userSet = await client
             .Child("Users/")//Prospect list
            .OnceSingleAsync<Users>();

            int checkCred = userSet.validate(name, pws);

            if (checkCred == 1)
            {
                this.Hide();
                User current = new User();
                current.UserName = name;
                current.Password = pws;
                ParkingLot engine = new ParkingLot();
                engine.setUser(current);
                engine.setUsers(userSet);
                engine.ShowDialog();
                this.Close();

            }
            else
            {
                label.Text = "Wrong Username or Password";
                usernameBox.Text = passwordBox.Text = "";
            }





        }




        private void loginBtn_Click_1(object sender, EventArgs e)
            {
                getUserDataAsync(usernameBox.Text, passwordBox.Text);
                //string name = usernameBox.Text;
                //string pws = passwordBox.Text;

                //Users userSet = new Users();
                //User temp = new User();
                //temp.level = 1;
                //temp.Password = "pass";
                //temp.UserName = "admin";
                //userSet.data = new User[1];
                //userSet.data[0] = temp;


                //int checkCred = userSet.validate(name, pws);
    
                //if (checkCred == 1)
                //{
                //    this.Hide();
                //    User current = new User();
                //    current.UserName = name;
                //    current.Password = pws;
                //    ParkingLot engine = new ParkingLot();
                //    engine.setUser(current);
                //    engine.ShowDialog();
                //    this.Close();

                //}
                //else
                //{
                //    label.Text = "Wrong Username or Password";
                //    usernameBox.Text = passwordBox.Text = "";
                //}

        }


        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
