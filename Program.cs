using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var joesEngineFactory = new EngineFactory();
            
            var v4 = joesEngineFactory.Create(4);

            var car1 = new Car{
                Engine = v4
            };

            var car2 = new Car{
                Engine = v4
            };

            System.Console.WriteLine(car1.Engine.IsBroken);
            car2.Engine.IsBroken = true;
            System.Console.WriteLine(car1.Engine.IsBroken);






            
            var natesCarFactory = new CarFactory()
            {
                EngineFactory = joesEngineFactory
            };
            var mustang = natesCarFactory.CreateNewMustang();

        }
    }
}
