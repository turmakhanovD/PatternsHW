using System;


namespace HWTelephone
{
    class Program
    {
        static void Main(string[] args)
        {
            var display = new Display();
            var firstBattery = new Battery { Percent = 41 };
            var secondBattery = new Battery { Percent = 87 };

            var samsung = new Manufacturer { PhoneName = "Samsung Galaxy Note 7", Price = 1500, Battery = firstBattery, Display = display };
            var iPhone = new Manufacturer { PhoneName = "IPhone X", Price = 1900, Battery = secondBattery, Display = display };

            samsung.GetInfo();
            iPhone.GetInfo();

            Console.Read();
        }
    }

    public interface IManufacturer
    {
        void GetInfo();
    }

    public interface IDisplay
    {
        void GetBatteryInfo(Battery battery);
    }

    public interface IBattery
    {
        void GetInfo();
    }

    public class Battery : IBattery
    {
        public int Percent { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"{Percent}%");
        }
    }

    public class Display : IDisplay
    {
        public void GetBatteryInfo(Battery battery)
        {
            Console.Write("Current battery percentage: ");
            battery.GetInfo();
        }
    }

    public class Manufacturer : IManufacturer
    {
        public string PhoneName { get; set; }
        public int Price { get; set; }
        public Display Display { get; set; }
        public Battery Battery { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"Phone: {PhoneName}\nPrice: {Price}$");
            Display.GetBatteryInfo(Battery);
        }
    }
}
