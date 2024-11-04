using System;


    public interface IProduct
    {
        void DisplayInfo();
    }

    public interface IShoppable
    {
        void AddToCart();
    }

    public class ElectronicDevice : IProduct
    {
        public string DeviceName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }

        public ElectronicDevice(string deviceName, string manufacturer, decimal price)
        {
            DeviceName = deviceName;
            Manufacturer = manufacturer;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Назва: {DeviceName}, Виробник: {Manufacturer}, Ціна: ${Price}");
        }
    }

    public class Smartphone : ElectronicDevice, IShoppable
    {
        public int BatteryCapacity { get; set; } 
        public int CameraResolution { get; set; } 

        public Smartphone(string deviceName, string manufacturer, decimal price, int batteryCapacity, int cameraResolution)
            : base(deviceName, manufacturer, price)
        {
            BatteryCapacity = batteryCapacity;
            CameraResolution = cameraResolution;
        }

        public void AddToCart()
        {
            Console.WriteLine($"{DeviceName} було додано до кошика.");
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Місткість батареї: {BatteryCapacity} мА·год, Роздільна здатність камери: {CameraResolution} Мп");
        }
    }

    public class Laptop : ElectronicDevice, IShoppable
    {
        public int RAM { get; set; } 
        public int Storage { get; set; } 

        public Laptop(string deviceName, string manufacturer, decimal price, int ram, int storage)
            : base(deviceName, manufacturer, price)
        {
            RAM = ram;
            Storage = storage;
        }

        public void AddToCart()
        {
            Console.WriteLine($"{DeviceName} було додано до кошика.");
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Оперативна пам'ять: {RAM} ГБ, Накопичувач: {Storage} ГБ");
        }
    }

    public class StoreTest
    {
        public static void Main()
        {
            Smartphone smartphone1 = new Smartphone("Galaxy S21", "Samsung", 799.99m, 4000, 108);
            Laptop laptop1 = new Laptop("MacBook Pro", "Apple", 1299.99m, 16, 512);

            smartphone1.DisplayInfo();
            smartphone1.AddToCart();

            Console.WriteLine();

            laptop1.DisplayInfo();
            laptop1.AddToCart();
        }
    }


