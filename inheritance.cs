using System;
class Car{

public string color="green"; 
public void drive()
{
   
   Console.WriteLine("i am driving");

}



}
   class Bmw:Car
   {
     
   public string speed="high";
   
   }

 
    public class Program{
    static void Main(string[]args)
    {
        Bmw car1=new Bmw();
        car1.drive();
        Console.WriteLine(car1.color);
        Console.WriteLine(car1.speed);
        Console.WriteLine(Math.Sqrt(64));
    
    
    }
 
 
 
 
 }
