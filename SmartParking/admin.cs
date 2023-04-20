using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;

namespace TeamVaxxers
{
    public partial class admin : Form
    {
        Graphics G;
        User current;
        Users userList;
        CarList Cars;
        Beacons beaconList;
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
           Task c = getCarDataAsync();
            //c.Wait();
            

            c = getBeaconDataAsync();
            //c.Wait();
            
           
            


        }
        private  async Task  getCarDataAsync() // grabs population from database 
        {

            Cars = await client
            .Child("Cars/")//Prospect list
           .OnceSingleAsync<CarList>();
            foreach (var value in Cars.data)
            {
                ListViewItem newList = new ListViewItem(value.owner);
                newList.SubItems.Add((value.color));
                newList.SubItems.Add((value.plate));
                newList.SubItems.Add(Convert.ToString(value.connected));
                ListCars.Items.Add(newList);


            }




        }
        private async Task getBeaconDataAsync() // grabs population from database 
        {

            beaconList = await client
            .Child("Beacons/")//Prospect list
           .OnceSingleAsync<Beacons>();
            foreach (var value in beaconList.data)
            {
                if (value.connected == null|| value.connected=="")
                {
                    ListViewItem newList = new ListViewItem("*");
                    
                    newList.SubItems.Add((""));
                    newList.SubItems.Add((""));
                    newList.SubItems.Add(Convert.ToString(value.Id));
                    ListCars.Items.Add(newList);
                }

            }

        }
        private async void addUserFirebase()// assumption that the userlist in firebase is not changed from firebase, at least while program is running 
        {
            await client
                    .Child("Users")
                    .PatchAsync(userList);

        }
        private async void addCarFirebase()// assumption that the userlist in firebase is not changed from firebase, at least while program is running 
        {
            await client
                    .Child("Cars")
                    .PatchAsync(Cars);

        }
        private async void addBeaconFirebase()// assumption that the userlist in firebase is not changed from firebase, at least while program is running 
        {
             await client
                    .Child("Beacons")
                    .PatchAsync(beaconList);

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
                ListUsers.Items.Remove(ListUsers.FindItemWithText(removeUserBox.Text,true, 0, false));
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

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            if(addDriver.Text.Contains("*"))
            {
                MessageBox.Show("Driver names can not contain ~");

            }
            int check = Cars.addCars(addDriver.Text,addColor.Text,addPlate.Text);
            if (check == -1)
            {


                MessageBox.Show("Car with plate number" + addPlate.Text + " already exists");
            }
            else
            {
                ListViewItem newList = new ListViewItem(addDriver.Text);
                newList.SubItems.Add((addColor.Text));
                newList.SubItems.Add((addPlate.Text));
                newList.SubItems.Add(Convert.ToString(-1));
                ListCars.Items.Add(newList);
                addCarFirebase();


            }


        }

        private void removeCarBtn_Click(object sender, EventArgs e)
        {
            long check = Cars.removeCars(removePlate.Text, beaconList);
            if (check == -1)
            {


                MessageBox.Show("Car with plate " + removePlate.Text + " does not exist");
            }
            else if(check ==-2)
            {
                ListCars.Items.Remove(ListCars.FindItemWithText(removePlate.Text, true, 0, false));

                addCarFirebase();
            }
            else
            {
                ListCars.Items.Remove(ListCars.FindItemWithText(removePlate.Text));
                //only car is removed so need to put the beacon id in 
                ListViewItem newList = new ListViewItem("~");
                newList.SubItems.Add((""));
                newList.SubItems.Add((""));
                newList.SubItems.Add(Convert.ToString(check));
                ListCars.Items.Add(newList);
                addCarFirebase();





            }
        }

        private void addBeaconBtn_Click(object sender, EventArgs e)
        {
            if(addBeacon.Text.All(char.IsDigit)==false || addBeacon.Text.Equals(""))
            {
                MessageBox.Show("Beacon Id must be positive a number");
                return;
            }
        
            int check = beaconList.addBeacon((long)Convert.ToInt64(addBeacon.Text));
            if (check == -1)
            {


                MessageBox.Show("Beacon with Id" + addBeacon.Text) + " already exists");
            }
            else
            {
                ListViewItem newList = new ListViewItem("*");
                newList.SubItems.Add((""));
                newList.SubItems.Add((""));
                newList.SubItems.Add(addBeacon.Text);
                ListCars.Items.Add(newList);
                addBeaconFirebase();


            }


        

    }
    }
}
