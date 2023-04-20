using System;
using System.Collections.Generic;
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
        public string connected;
        public int inside;
        void trilaterate(Sensors location, Parking slotPos)
        {

        }

    }
    public class Beacons
    {
        public int Total { get; set; }
        public List<Beacon> data { get; set; }

        public int addBeacon(long id)
        {
            
            foreach (var b1 in this.data)
            {
                if (b1.Id == id)
                {
                    return -1;
                }


            }
            Total++;
            Beacon temp = new Beacon();
            temp.Id = id;
            temp.D1 = -1;
            temp.D2 = -1;
            temp.D3 = -1;
            temp.D4 = -1;
            temp.connected = null;
            data.Add(temp);
            return 0;


            

        }
        public int removeBeacon(int id, CarList list)
        {
            int i = 0;
            foreach (var b1 in this.data)
            {
                i++;
                
                if (b1.Id == id)
                {
                    if(b1.connected!=null)
                    {
                        foreach( var car1 in list.data)
                        {
                            if(b1.connected ==car1.plate)
                            {
                                car1.connected = -1;
                            }
                        }
                    }
                    this.data.Remove(b1);
                    this.Total--;
                    return 0;
                }



            }
            return -1;


        

    }
        public int modify(long id1, long id2, CarList list)
        {
            foreach (var b1 in this.data)
            {
                //i++;

                if (b1.Id == id1)
                {
                   
                    foreach (var b2 in this.data)
                    {
                        if (b2.Id == id2)
                        {
                            string temp = b1.connected;
                            b1.connected = null;
                            string temp1 = b2.connected;
                            b2.connected = null;

                                
                            foreach (var car1 in list.data)// switch cars id for b1
                            {
                                if (temp == car1.plate)
                                {
                                    car1.connected = b2.Id;
                                    b2.connected = temp;
                                        
                                }
                                    
                            }
                            foreach (var car1 in list.data)//swirch cars id for b2
                            {
                                if (temp1 == car1.plate)
                                {
                                    car1.connected = b1.Id;
                                    b2.connected = temp1;

                                }

                            }


                            return 0;
                        }
                    }


                    return -1;
                   
                   
                }



            }
            return -2;


        }

    }
    public class Parking
    {
        public List<Slot> data { get; set; }//should only be 6 slots
        public int Total { get; set; }
        public int number;

        Slot checkSlot(Beacon ID)
        {
            return data[1]; //placeholder so no error
        }

    }
    public class Slot
    {

        public List<Point> vertice { get; set; }//should onyl be 4 points
        
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
        public List<Sensor> data { get; set; }// should only be 4 sensors
        public int Total;

    }
    public class Sensor
    {
        public Point location { get; set; }

    }
    public class CarList
    {
        public List<Car> data { get; set; }
        public int Total { get; set; }
        public int addCars(string owner, string color, string plate )
        {
            foreach (var car1 in this.data)
            {
                if (car1.plate == plate)
                {
                    return -1;
                }


            }
            Total++;
            Car temp = new Car();
            temp.plate = plate;
            temp.color = color;
            temp.owner = owner;
            temp.connected = -1;
            data.Add(temp);
            return 0;


        }
        public long removeCars(string plate, Beacons list)
        {
            //int i = 0;
            foreach (var car1 in this.data)
            {
                //i++;
                
                if (car1.plate == plate)
                {
                    if (car1.connected != -1)
                    {
                        foreach (var b1 in list.data)
                        {
                            if (b1.Id == car1.connected)
                            {
                                b1.connected = null;
                                return b1.Id;
                            }
                        }
                    }
                    this.data.Remove(car1);
                    this.Total--;
                    return -2;//beacon ids prob can't be zero but definnitly cant be negative
                }



            }
            return -1;


        }



        public int connect(Beacons list, int id, string plate)
        {
            int check =-1;
            Car temp;
            Beacon temp1;
            foreach (var c1 in this.data)
            {
                if(c1.plate==plate)
                {
                    check = 1;
                    
                    c1.connected = id;
                }
               


            }
            if(check==-1)
            {
                return -1;
            }
            foreach (var b1 in list.data)
            {
                if (b1.Id == id)
                {
                    check = 1;
                    b1.connected = plate;
                    return 0;
                }



            }
        
            foreach (var c1 in this.data)//if beacon doesnt exist turn connected back to -1
            {
                if (c1.plate == plate)
                {
                        

                    c1.connected = -1;
                }



            }

            return -2;
            
            


        }
       
        public int modify(Beacons list, string plate1, string plate2 )
        {
            foreach (var c1 in this.data)
            {
                //i++;

                if (c1.plate == plate1)
                {

                    foreach (var c2 in this.data)
                    {
                        if (c2.plate == plate2)
                        {
                            long temp = c1.connected;
                            c1.connected = -1;
                            long temp1 = c2.connected;
                            c2.connected = -1;


                            foreach (var beacon in list.data)// switch cars id for b1
                            {
                                if (temp == beacon.Id)
                                {
                                    beacon.connected = c1.plate;
                                    c2.connected = temp;

                                }

                            }
                            foreach (var beacon in list.data)//swirch cars id for b2
                            {
                                if (temp1 == beacon.Id)
                                {
                                    beacon.connected = c2.plate;
                                    c1.connected = temp1;

                                }

                            }


                            return 0;
                        }
                    }


                    return -1;


                }



            }
            return -2;


        }

    }

    
    public class Car
    {
       public  long connected;
        public string plate;
        public string owner;
        public string color;

    }
}

