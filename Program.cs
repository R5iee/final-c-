using System;
using System.Diagnostics;
using System.Dynamic;

public class Vehicle{

public string name;
private int speed;

public static int TotalVehicles;

public Vehicle (string name , int speed ){
    this.name = name;
    this.speed = speed;

    TotalVehicles++;
}
public void start(){
    Console.WriteLine("vehicis is starting!");

}
public void Aceelerate(int TotalVehicles ){
 TotalVehicles=speed;

}
public int GetSpeed(){
    return speed;
}

 class Car{
    
    public int FuelEfficiency{get;set;}
    public string name; 
    public Car (string v, int FuelEfficiency , string name){
        name = name;

        
    }

        public Car(int fuelEfficiency, string name)
        {
            FuelEfficiency = fuelEfficiency;
            this.name = name;
        }

        class Motorcycle : Car
        {
            public void start(){
                Console.WriteLine("the car isstarting with a smooth engine sound! ");
            }
             Motorcycle(int FuelEfficiency, string name) : base(FuelEfficiency, name){
            {
                
            }
            }
        }
        class Tank : Car
        {
            public Tank(int FuelEfficiency, string name) : base(FuelEfficiency, name)
            {

            }
            public void CargoCapacity(){

            }
        }
        




    }
    class TestArray{
        static void Main(){
            Vehicle[]Vehicle= new Vehicle[3]
                Car car = new Car ("car A", 100, 150  );
            Motorcycle motorcycle = new Motorcycle ("Motorcycle b " ,200 , 60 );
            Trace truck = new Trace ("Truck c",100 , 130 );
            
            Speed speed = new Speed();
        }
        
    

    } 

}

internal class Motorcycle
{
    private string v1;
    private int v2;
    private int v3;

    public Motorcycle(string v1, int v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }
}

internal class Speed
{
}