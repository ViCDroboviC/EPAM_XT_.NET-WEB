using System;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Airplane B737 = new Airplane("Boeing", "b 737", 15000, 0, 0);
            Console.WriteLine("Введите координаты для перемещения:");
            //TODO написать проверку вводимых с клавиатуры даных
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            B737.FlyTo(x, y); 
            Console.ReadKey();
            AttackJet A10C = new AttackJet("Fairchild", "A-10C", 8000, 7257, 10);
            //TODO Перегрузить конструктор для приема массы пустого и максимальной массы и вычисления боевой нагрузки по ней
            AttackJet AV8 = new AttackJet("McDonnel Douglas", "AV-8B", 9500, 4000, 7);
        }
    }
}
