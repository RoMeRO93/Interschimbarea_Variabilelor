using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Introduceti primul numar a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0}, b={1}", a, b);

            int temp = a;
            a = b;
            b = temp;

            Console.Write("Dupa interschimbare a={0}, b={1}", a, b);
            Console.ReadKey();
        }
    }
}
