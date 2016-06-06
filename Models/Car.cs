using System;
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal CurrentSpeed { get; private set; }
    public Engine Engine { get; set; }

    public void Accelerate(int speed)
    {
        if (Engine != null)
        {
            CurrentSpeed = speed;
            Console.WriteLine("Set current speed to " + speed);
            
        }else{
            Console.WriteLine("Yo you can't run without an Engine");
        }
    }
}




