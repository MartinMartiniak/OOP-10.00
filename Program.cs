using System;

namespace OOP_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("Martinkove coding adventures", 200, "Family Comedy", "Martin Martiniak", 2020);
            Console.WriteLine(LOTR.ToString());
        }
    }
}
