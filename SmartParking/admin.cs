using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeamVaxxers
{
    public partial class admin : Form
    {
        Graphics G;
        public admin()
        {
            InitializeComponent();
        }
        private void displayBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ParkingLot engine = new ParkingLot();
            engine.ShowDialog();
            this.Close();


        }

        private void admin_Load(object sender, EventArgs e)
        {
            G = this.CreateGraphics();
            
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
    }
}
