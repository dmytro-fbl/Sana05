using ConsoleProgram;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Vehicle[] vehicles = new Vehicle[4];
        vehicles[0] = new Car("Tesla", "Model 3", 2023, 1500000, 4, "електро");
        vehicles[1] = new Car("Toyota", "Camry", 2022, 850000, 4, "бенз");
        vehicles[2] = new Truck("MAN", "TGX", 2021, 2500000, 20, 3);
        vehicles[3] = new Motorcycle("Honda", "CRF1100L Africa Twin", 2024, 650000, 1084, true);

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.DisplayInfo() + "\n");
        }
    }
}
