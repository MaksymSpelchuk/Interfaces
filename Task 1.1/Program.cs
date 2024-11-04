using System;


    public interface IVehicle
    {
        void Start(); 
        void Stop();  
        void Drive(); 
    }

    public class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int numberOfDoors)
        {
            Brand = brand;
            Model = model;
            NumberOfDoors = numberOfDoors;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} {Model} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} {Model} is stopping.");
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} is driving.");
        }

        public void OpenDoors()
        {
            Console.WriteLine($"Opening all {NumberOfDoors} doors of {Brand} {Model}.");
        }
    }

    public class Motorcycle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, string model, bool hasSidecar)
        {
            Brand = brand;
            Model = model;
            HasSidecar = hasSidecar;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} {Model} motorcycle is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} {Model} motorcycle is stopping.");
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} motorcycle is driving.");
        }

        public void CheckSidecar()
        {
            if (HasSidecar)
                Console.WriteLine($"{Brand} {Model} has a sidecar attached.");
            else
                Console.WriteLine($"{Brand} {Model} does not have a sidecar.");
        }
    }

    public class Truck : IVehicle
    {
        public string Brand { get; set; }
        public int LoadCapacity { get; set; }

        public Truck(string brand, int loadCapacity)
        {
            Brand = brand;
            LoadCapacity = loadCapacity;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} truck is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} truck is stopping.");
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} truck is driving.");
        }

        public void LoadCargo(int weight)
        {
            if (weight <= LoadCapacity)
                Console.WriteLine($"Loading {weight} kg of cargo into {Brand} truck.");
            else
                Console.WriteLine($"Cannot load {weight} kg. Exceeds the load capacity of {LoadCapacity} kg.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Camry", 4);
            Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Street 750", true);
            Truck truck = new Truck("Volvo", 10000);

            car.Start();
            car.Drive();
            car.Stop();
            car.OpenDoors();

            motorcycle.Start();
            motorcycle.Drive();
            motorcycle.Stop();
            motorcycle.CheckSidecar();

            truck.Start();
            truck.Drive();
            truck.Stop();
            truck.LoadCargo(5000); 
            truck.LoadCargo(15000); 
        }
    }


