using Company.Classes;

Boat boat001 = new Boat(40, "gray", "boat001", "B", false, 0, 70);
Boat boat002 = new Boat(80, "green", "boat002", "B", false, 0, 90);
Boat boat003 = new Boat(15, "blue", "boat003", "A", true, 0, 7);

Car car100 = new Car(170, "black", "car100", "B", false, 4, 200);
Car car101 = new Car(200, "pink", "car101", "B", true, 4, 350);
Car car102 = new Car(240, "purple", "car102", "B", true, 4, 400);
Car car103 = new Car(200, "gray", "car103", "B", false, 6, 500);

Bike bike200 = new Bike(30, "yellow", "bike200", "-", true, 2, 0);
Bike bike201 = new Bike(10, "pink", "bike201", "-", false, 4, 0);
Bike bike202 = new Bike(20, "white", "bike202", "-", true, 2, 0);

Motorbike motorbike300 = new Motorbike(90, "orange", "motorbike300", "A1", false, 2, 50.5);
Motorbike motorbike301 = new Motorbike(120, "ice blue", "motorbike301", "A", true, 2, 77.7);
Motorbike motorbike302 = new Motorbike(130, "silver", "motorbike302", "A", false, 2, 80.2);
Motorbike motorbike303 = new Motorbike(70, "brown", "motorbike303", "A1", true, 3, 40.2);
Motorbike motorbike304 = new Motorbike(143, "soft pink", "motorbike304", "A", false, 2, 100);

Scooter scooter400 = new Scooter(30, "gold", "scooter400", "-", true, 2, 10);
Scooter scooter401 = new Scooter(10, "lilac", "scooter401", "-", false, 3, 0);
Scooter scooter402 = new Scooter(24, "mint", "scooter402", "-", true, 2, 7);

List<Transport> transports = new List<Transport>()
{
    boat001, motorbike302, motorbike303, boat002, boat003, car100, car101, scooter400, scooter401, car102, car103, bike200, bike202, motorbike300, motorbike301, motorbike304, bike201, scooter402
};


transports.Sort((s1, s2) => s1.GetType().Name.CompareTo(s2.GetType().Name));

Console.WriteLine("Company transport property:\n");

foreach (var transport in transports)
{
    transport.Print();
}

bool program = true;

while (program == true) {
    Console.WriteLine("\nWhat do you want to do: find a model or exit?");
    string action = Console.ReadLine();

    if (action == "find a model") { 
        Console.WriteLine("\nEnter model name:");
        string model = Console.ReadLine();

        var matchingTransport = transports.FindAll(p => p.Model.Equals(model, StringComparison.OrdinalIgnoreCase));

        foreach (var transport in matchingTransport)
        {
            Console.WriteLine($"Model {transport.Model} {(transport.IsRented ? "is ranted" : "is not ranted")}");
        }
    } else if (action == "exit")
    {
        program = false;
    } else
    {
        Console.WriteLine("\nERROR! Enter one of the commands: find a model or exit!");
        action = Console.ReadLine();
    }
}