using System;

namespace HWComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            MotherBoard board = new MotherBoard();
            var firstProc = new Processor { Name = "Intel Core i9" };
            var secondProc = new Processor { Name = "Intel Core i7" };

            var firstPC = new Computer { Name = "Hp Pavillion 9", Price = 1400, MotherBoard = board, Processor = firstProc };
            var secondPC = new Computer { Name = "iMac Pro", Price = 2000, MotherBoard = board, Processor = secondProc };

            firstPC.GetInfo();
            secondPC.GetInfo();
            Console.Read();
        }
    }

    public interface IComputer
    {
        void GetInfo();
    }

    public interface IMotherBoard
    {
        void GetProcInfo(Processor processor);
    }

    public interface IProcessor
    {
        void GetInfo();
    }

    public class Processor : IProcessor
    {
        public string Name { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Processor: {Name}");
        }
    }

    public class MotherBoard : IMotherBoard
    {
        public void GetProcInfo(Processor processor)
        {
            Console.WriteLine("Proc in this mother board: ");
            processor.GetInfo();
        }
    }

    public class Computer : IComputer
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public MotherBoard MotherBoard { get; set; }
        public Processor Processor { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"PC: {Name}\nPrice:{Price}$");
            MotherBoard.GetProcInfo(Processor);
        }
    }
}
