using System;

public class Engine
{
    public string Name { get; set; }
    public int Cylinders { get; set; }
    public bool IsBroken { get; private set; }

    public void Explode(){
            IsBroken = true;
            Console.WriteLine("Your engine is engulfed in flames.");
    }
}