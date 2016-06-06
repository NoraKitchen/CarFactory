public class CarFactory
{
    public EngineFactory EngineFactory { get; set; } 

    public Car CreateCar(string make, string model, int year, int cylinders)
    {
        var engine = EngineFactory.Create(cylinders);
        return new Car{
            Make = make,
            Model = model,
            Year = year, 
            Engine = engine
        };
    }

    public Car CreateNewMustang(){
        
        return CreateCar("Ford","Mustang",2016, 8);
    }

    public Car CreateNewF150(){
        return CreateCar("Ford","F150",2016, 12);
    }

}