namespace TeamVaxxers
{


    public class Beacon
    {
        public double D1 { get; set; }
        public double D2 { get; set; }
        public double D3 { get; set; }
        public double D4 { get; set; }
        public long Id { get; set; }
        public long Time { get; set; }
        string connected;
        int inside;
        void trilaterate(Sensors location, Parking slotPos)
        {

        }

    }
    public class Beacons
    {
        public int Total { get; set; }
        public Beacon[] data { get; set; }

    }
    public class Parking
    {
        public Slot[] data { get; set; }//should only be 6 slots
        public int Total { get; set; }
        public int number;

        Slot checkSlot(Beacon ID)
        {
            return data[1]; //placeholder so no error
        }

    }
    public class Slot
    {

        public Point[] vertice { get; set; }//should onyl be 4 points
        
        public int Total { get; set; }

        int spot;
        char avialability; // a = available, o = occubied d= delinquent

        
        public void changeColor()
        {


        }
        public void clear()
        {

        }

        

        
    }
    public class Point
    {
        public int x;
        public int y;
    }
    public class Sensors
    {
        public Sensors[] data { get; set; }// should only be 4 sensors

    }
    public class Sensor
    {
        public Point location { get; set; }

    }
    public class CarList
    {
        public Car[] data { get; set; }
        void addCars()
        {

        }
        void removeCars()
        {

        }
        void addBeacon()
        {

        }
        void connect(Beacons list, int id, string plate)
        {

        }
        void connect(int id)
        {

        }
        void modifyB(int id1, int id2)
        {

        }
        void modifyC(string plate1, string plate2 )
        {

        }

    }
    public class Car
    {
        Beacon connected;
        string plate;
        string owner;
        string color;

    }
   
    public class Response

    {
        public bool success { get; set; }
        public int index { get; set; }
        public string message { get; set; }
        public string received { get; set; }
        public string companyId { get; set; }
        public string color { get; set; }
        public int[] infected { get; set; }

    }
}

