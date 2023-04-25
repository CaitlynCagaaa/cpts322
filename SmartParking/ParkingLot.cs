using Firebase.Database;
using Firebase.Database.Query;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TeamVaxxers
{
    public partial class ParkingLot : Form
    {
        //FirebaseClient client = new FirebaseClient("https://heymotocarro-1a1d4.firebaseio.com/");
        FirebaseClient client = new FirebaseClient(" https://parking-lot-f206b-default-rtdb.firebaseio.com/");
 
         Graphics G;
        Rectangle[] rect= new Rectangle[6];
        User current;
        Users userList;
        Parking Lot;
        Sensors sense;
        public ParkingLot()
        {
            InitializeComponent();
            // WindowState = FormWindowState.Maximized;

            //c.Wait();
            Task c = getParkingDataAsync();
            //c.Wait();
            //if(sense==null)
            // {
            //  MessageBox.Show("error: please fix database and resart program if you want to use the parking display");
            //  return;
            //}

            c = getSensorDataAsync();
            //c.Wait();


        }
        public void setUser(User currUser)
        {
            current = currUser;
        }
        public void setUsers(Users currUser)
        {
            userList= currUser;
        }
        private void ParkingLot_Load(object sender, EventArgs e)
        {
            G = this.CreateGraphics();

            getBeaconDataAsync();



            //draw parking numbers
        }
        private void trilaterate(Beacon beacon)
        {
            
           
               Point pt = beacon.trilateratetion(sense);
            
            
              beacon.inside = Lot.checkSlot(pt, beacon.Id);
            
            //call parking lot method to check for filled slots
            
            this.Paint += repaint;
            
            //repaint
        }
        private void loadData(object sender, EventArgs e)
        {
            
        }
        private void repaint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 0);
            SolidBrush myBrush = new SolidBrush(Color.FloralWhite);
            SolidBrush myBrush2 = new SolidBrush(Color.YellowGreen);
            SolidBrush myBrush3 = new SolidBrush(Color.Red);
            for ( int i=0;i<6;i++)
            {
                if(Lot.data[i].avialability=='a')
                {
                    G.FillRectangle(myBrush, rect[i]);
                    G.DrawRectangle(blackPen, rect[i]);


                }
                else if(Lot.data[i].avialability == 'o')
                {
                    G.FillRectangle(myBrush2, rect[i]);
                    G.DrawRectangle(blackPen, rect[i]);
                }
                else if (Lot.data[i].avialability == 'd' || Lot.data[i].avialability == 'b')
                {
                    G.FillRectangle(myBrush3, rect[i]);
                    G.DrawRectangle(blackPen, rect[i]);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                DrawStringFloatFormat((i + 1).ToString(), 100 * i + 50, 200.0F);
            }
            for (int i = 0; i < 3; i++)
            {
                DrawStringFloatFormat((i + 3).ToString(), 100 * (i) + 50, 450.0F);
            }
        }
        private void DrawSlots(object sender,  PaintEventArgs e)//TODO: parking lot classes, trilateration of parking lots, auto update rather than button update.
        {
            Pen blackPen = new Pen(Color.Black, 0);
            SolidBrush myBrush = new SolidBrush(Color.FloralWhite);
            SolidBrush myBrush2 = new SolidBrush(Color.YellowGreen);


            // Create rectangle and Draw rectangle to screen.
            for (int i = 0; i < 3; i++)
            {
                rect[i] = new Rectangle(100 * i, 100, 100, 200);
                G.FillRectangle(myBrush, rect[i]);
                G.DrawRectangle(blackPen, rect[i]);
                DrawStringFloatFormat((i + 1).ToString(), 100 * i + 50, 200.0F);
            }
            Rectangle[] street = new Rectangle[1];
            street[0] = new Rectangle(0, 300, 300, 50);
            G.FillRectangle(myBrush, street[0]);
            G.DrawRectangle(blackPen, street[0]);

            for (int i = 0; i < 3; i++)
            {
                rect[i + 3] = new Rectangle(100 * i, 350, 100, 200);
                G.FillRectangle(myBrush, rect[i + 3]);
                G.DrawRectangle(blackPen, rect[i + 3]);
                DrawStringFloatFormat((i + 3).ToString(), 100 * (i) + 50, 450.0F);
            }
        }
            
        private async void getBeaconDataAsync() // grabs population from database 
        {
            
    
            //******************** Get initial list of beacons ***********************//
            var BeaconsSet = await client
               .Child("Beacons/")//Prospect list
               .OnceSingleAsync<Beacons>();
            displayBeaconsData(BeaconsSet);

            foreach(var beac in BeaconsSet.data)
            {
                trilaterate(beac);
            }


            //******************** Get changes on beacons ***********************//
            onChildChanged();


        }
        private async Task getParkingDataAsync() // grabs population from database 
        {


            //******************** Get initial list of beacons ***********************//
            Lot = await client
               .Child("ParkingMap/")//Prospect list
               .OnceSingleAsync<Parking>();

            foreach(var slot in Lot.data)
            {
                slot.avialability = 'a';
                slot.spot = -1;

            }


            

        }
        private async Task getSensorDataAsync()
        {
            sense = await client
               .Child("Sensors/")//Prospect list
               .OnceSingleAsync<Sensors>();
        }

            private void onChildChanged() // Waits for data base to start with variable
        {


            var child = client.Child("Beacons/data");
            var observable = child.AsObservable<Beacon>();
            var subscription = observable
                .Subscribe(x =>
                {
                    trilaterate(x.Object);

                });
           
        }
        public void DrawStringFloatFormat(String drawString, float x, float y)
        {
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);          

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
           // drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            // Draw string to screen.
            G.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
        }

        private void displayBeaconsData(Beacons beacons) // display beacons
        {
            foreach (var beacon in beacons.data)
            {
                Console.WriteLine($"beacon id: { beacon.Id} [{ beacon.D1}]");
            }

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin engine = new admin(this);
            engine.setUser(current);
            engine.setUsers(userList);
            engine.ShowDialog();
            //this.Close();

        }
    }
}
