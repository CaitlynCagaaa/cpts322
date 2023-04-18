using System;
using System.Drawing;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace TeamVaxxers
{
    public partial class admin : Form
    {
        Graphics G;
        User current;
        Users userList;
        FirebaseClient client = new FirebaseClient("https://parking-lot-f206b-default-rtdb.firebaseio.com");
        public admin()
        {
            InitializeComponent();
        }
        private void displayBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ParkingLot engine = new ParkingLot();
            engine.setUser(current);
            engine.setUsers(userList);
            engine.ShowDialog();
            this.Close();


        }

        private void admin_Load(object sender, EventArgs e)
        {
            G = this.CreateGraphics();
            

            foreach (var value in userList.data)
            {
                ListViewItem newList = new ListViewItem(value.UserName);
                newList.SubItems.Add(Convert.ToString(value.level));
                ListUsers.Items.Add(newList);
            }
            
        }
        private async void addUserFirebase()// assumption that the userlist in firebase is not changed from firebase, at least while program is running 
        {
            await client
                    .Child("Users")
                    .PatchAsync(userList);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            int check = userList.removeUser(removeUserBox.Text);
            if (check == -1)
            {


                MessageBox.Show("User " + removeUserBox.Text + " does not exist");
            }
            else if(check==-2)
            {
                MessageBox.Show("You can't delete the adminstrator user");

            }
            else
            {
                ListUsers.Items.Remove(ListUsers.FindItemWithText(removeUserBox.Text));
                addUserFirebase();



            }
        }

    

        private void oldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void oldBeacon_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void collUser_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2Collapsed == false)
            {
                splitContainer2.Panel2Collapsed = true;
                splitContainer2.Size = new Size(1235, 30);
            }
            else
            {
                splitContainer2.Panel2Collapsed = false;
                splitContainer2.Size = new Size(1235, 260);
            }
        }

        private void collChange_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == false)
            {
                splitContainer1.Panel2Collapsed = true;
                splitContainer1.Size = new Size(1235, 30);
                //splitContainer1.Panel2.SuspendLayout();
            }
            else
            {
                splitContainer1.Panel2Collapsed = false;
                //splitContainer1.Size = new Size(1235, 100);
                splitContainer1.Size = new Size(1235, 100);
            }
        }

        private void collCar_Click(object sender, EventArgs e)
        {
            if (splitContainer3.Panel2Collapsed == false)
            {
                splitContainer3.Panel2Collapsed = true;
                splitContainer3.Size = new Size(1235, 30);
            }
            else
            {
                splitContainer3.Panel2Collapsed = false;
                splitContainer3.Size = new Size(1235, 375);
            }

        }
       

        private void addUserBtn_Click(object sender, EventArgs e)
        {
           int check = userList.addUser(addUserBox.Text, addPassword.Text);
            if (check == -1)
            { 
            
            
                MessageBox.Show("User" + addUserBox.Text + " already exists");
            }
            else
            {
                ListViewItem newList = new ListViewItem(addUserBox.Text);
                newList.SubItems.Add(Convert.ToString(0));
                ListUsers.Items.Add(newList);
                addUserFirebase();
                


            }
        }

        private void removeUserBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
