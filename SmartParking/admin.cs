using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeamVaxxers
{
    public partial class admin : Form
    {
        Graphics G;
        User current;
        Users userList;
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {

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
    }
}
