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
            if (Engine.IsBroken != true)
            {
                CurrentSpeed = speed;
                Console.WriteLine("Set current speed to " + speed);
                if (CurrentSpeed > 80){
                    Engine.Explode();
                }
            }
            else
            {
                Console.WriteLine("You have attmpted to accelerate with a broken engine.");
                Console.WriteLine("Your engine fire grows.");
                Explode();
            }

        }
        else
        {
            Console.WriteLine("You can't run without an Engine");
        }
    }

    public void Explode(){
        Console.WriteLine("Your car has now exploded.");
        Make = "Irrecognizable";
        Model = "Mangled";
        CurrentSpeed = 0;
    }
}




