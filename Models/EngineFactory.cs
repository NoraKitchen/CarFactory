public class EngineFactory
{
    public Engine Create(int cylinders)
    {
        return new Engine
        {
            Name = "v" + cylinders.ToString(),
            Cylinders = cylinders
        };
    }
}