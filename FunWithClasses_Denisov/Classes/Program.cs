using System;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane B737 = new Airplane("Boeing", "b 737", 15000);
            B737.FlyTo(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); 
            Console.ReadKey();
        }
    }
}
