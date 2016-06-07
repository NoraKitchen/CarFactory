using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var joesEngineFactory = new EngineFactory();
            var natesCarFactory = new CarFactory()
            {
                EngineFactory = joesEngineFactory
            };
            var mustang = natesCarFactory.CreateNewMustang();
            
            mustang.Accelerate(25);
            mustang.Accelerate(100);
            mustang.Accelerate(110);

        }
    }
}
