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
        public Point trilateratetion(Sensors location)
        {
            //do trlateration for specific pt here 
            double A =Math.Abs( 2 * location.data[1].position.x - 2 * location.data[0].position.x);
            double B = Math.Abs( 2 * location.data[1].position.y - 2 * location.data[0].position.y);
            double C = Math.Abs( D1 * D1 - D2 * D2 - (location.data[0].position.x * location.data[0].position.x) +
                (location.data[1].position.x * location.data[1].position.x) - (location.data[0].position.y * location.data[0].position.y)
                + (location.data[1].position.y * location.data[1].position.y));
            double D = Math.Abs(2 * location.data[2].position.x - 2 * location.data[1].position.x);
            double E = Math.Abs(2 * location.data[2].position.y - 2 * location.data[1].position.y);

            double F = Math.Abs( D2 * D2 - D3 * D3 - (location.data[1].position.x * location.data[1].position.x) +
                (location.data[2].position.x * location.data[2].position.x) - (location.data[1].position.y * location.data[1].position.y)
                + (location.data[2].position.y * location.data[2].position.y));

            double G = Math.Abs( 2 * location.data[3].position.x - 2 * location.data[2].position.x);
            double H = Math.Abs(2 * location.data[3].position.y - 2 * location.data[2].position.y);

            double I = Math.Abs(D3 * D3 - D4 * D4 - (location.data[2].position.x * location.data[2].position.x) +
                (location.data[3].position.x * location.data[3].position.x) - (location.data[2].position.y * location.data[2].position.y)
                + (location.data[3].position.y * location.data[3].position.y));

            Point pt = new Point();
            double x1 = ((C*E -F*B)/ (E*A - B*D));
            double y1 = ((C * D - F * A) / (B * D - A * E));
            //double x2 = ((C * H- I * B) / (H * A - B * G));
            //double y2 = ((C * G - I * A) / (B * G - A * H));
            double x3 = (F * H - I * E) / (H * D - E * G);
            double y3 = (F * G - I * D) / (E * G - D * H);

            pt.x = (x1  + x3) / 2;
            pt.y = (y1+ y3) / 2;


            return  pt;
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
            int ret = -1;
            foreach (var b1 in this.data)
            {
                i++;
                
                if (b1.Id == id)
                {
                    ret = 0;
                    if(b1.connected!=null || b1.connected != "")
                    {
                        foreach( var car1 in list.data)
                        {
                            if(b1.connected ==car1.plate)
                            {
                                car1.connected = -1;
                                ret = -2;
                            }
                        }
                    }
                    this.data.Remove(b1);
                    this.Total--;
                    return ret;
                }



            }
            return ret;


        

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
        //public int number;

        public int checkSlot(Point pt, long ID )
        {
            int slotNum = -1;
            int i = 1;
            foreach(var slot in data)
            {
               
                if (slot.lowX < pt.x && slot.highX > pt.x && slot.lowY < pt.y && slot.highY > pt.y)
                {
                    
                    slot.changeColor(1, ID);
                    slot.spot = ID;
                    slotNum = i;
                    

                }
                else if (slot.position[0].x<pt.x && slot.position[1].x>pt.x && slot.lowY < pt.y && slot.highY > pt.y)
                {
                    slot.changeColor(0, ID);
                    slot.spot = ID;
                    if (slot.position[0].x < pt.x)
                    {
                        if (i != 1 && i !=4)
                        {
                            data[i - 2].changeColor(0, ID);

                        }
                    }
                    else if (slot.position[1].x > pt.x)
                    {
                        if (i != 3 && i != 6)
                        {
                            data[i].changeColor(0, ID);

                        }

                    }
                    slotNum = -2;
                }
                else if(slot.spot==ID || slot.prev==ID)
                {
                    slot.clear(ID);
                }
                i++;

            }
            return slotNum; //placeholder so no error
        }

    }
    public class Slot
    {

        public List<Point> position { get; set; }//should onyl be 4 points
        
        public int Total { get; set; }
        public double lowX;
        public double lowY;
        public double highX;
        public double highY;
        public long spot;
        public long prev;
        
        public char avialability; // a = available, o = occubied d= double b=bounds delinquent

        
        public void changeColor(int inside70, long ID)
        {
            if(inside70==1)
            {
                if(spot==-1 || spot==ID)
                {
                    avialability = 'o';
                    
                }
                else
                {
                    avialability = 'd';
                    prev = spot;
                    spot = ID;
                }

            }
            else
            {
                avialability = 'b';
                prev = spot;
                spot = ID;
            }


        }
        public void clear(long ID)
        {
            if(avialability == 'd')
            {
                avialability = 'o';
                if (ID == this.prev)
                {
                    prev = -1;
                }
                else
                {
                    spot = prev;
                    prev = -1;
                }
                return;

            }
            if(avialability == 'b')
            {
                avialability = 'a';
                spot = -1;
                prev = -1;
                return;
            }
            avialability = 'a';
            
            spot = -1;
            prev = -1;

        }

        

        
    }
    public class Point
    {
        public double x;
        public double y;
    }
    public class Sensors
    {
        public List<Sensor> data { get; set; }// should only be 4 sensors
        public int Total;

    }
    public class Sensor
    {
        public Point position { get; set; }

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
                                this.data.Remove(car1);
                                this.Total--;
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
            //Car temp;
            //Beacon temp1;
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
                return -1;// if car doesnt exist
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

            return -2;// if beacon doesnt exist 
            
            


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

