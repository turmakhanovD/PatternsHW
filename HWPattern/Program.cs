using System;

namespace HWCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var body = new Body();
            var engineToyota = new Engine { Name = "V12", Power = "1000 horse power" };
            var engineFord = new Engine { Name = "V8", Power = "800 horse power" };
            var toyota = new Car { Mark = "Toyota Camry", Price = 9000000, Engine = engineToyota, Body = body };
            var ford = new Car { Mark = "Ford Mustang", Price = 12000000, Engine = engineFord, Body = body };

            toyota.GetInfo();
            ford.GetInfo();

            Console.ReadLine();
        }
    }

    public interface ICar
    {
        void GetInfo();
    }

    public interface IBody
    {
        void GetInfo(Engine engine);
    }
    public interface IEngine
    {
        void GetInfo();
    }
    public class Engine : IEngine
    {
        public string Name { get; set; }
        public string Power { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"Engine:{Name} \nPower:{Power}");
        }
    }
    public class Body : IBody
    {
        public void GetInfo(Engine engine)
        {
            Console.WriteLine("Engine in body:");
            engine.GetInfo();
        }
    }

    public class Car : ICar
    {
        public string Mark { get; set; }
        public int Price { get; set; }
        public Body Body { get; set; }
        public Engine Engine { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"Mark of car: {Mark}\nPrice of car: {Price}");
            Body.GetInfo(Engine);
        }
    }


}
