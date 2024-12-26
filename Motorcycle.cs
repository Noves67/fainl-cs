using System;

public class Motorcycle:Vehicle{
    public Motorcycle(string Name, int Speed) : base(Name, Speed)
    {
    }

    public  void   Start(){
    Console.WriteLine("The motorcycle roars to life!");
    
    


    }
   
}