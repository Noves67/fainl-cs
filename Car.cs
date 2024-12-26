using System;

public class Car: Vehicle
{
    public Car(string Name, int Speed) : base(Name, Speed)
    {
    }

    public void start(){
    Console.WriteLine("The car is starting with a smooth engine sound!");
    
  }  
}