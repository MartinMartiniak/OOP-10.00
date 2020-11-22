using System;

namespace OOP_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            // Book LOTR = new Book("Martinkove coding adventures", 200, "Family Comedy", "Martin Martiniak", 2020);
            // Console.WriteLine(LOTR.ToString());
        
        
        Console.Write("Title: ");
            string title = Console.ReadLine();
        Console.Write("Pages: ");
            int pages = int.Parse(Console.ReadLine());
            if (pages < 0)
            {
                pages = 1;
            }
        Console.Write("Category: ");
            string category = Console.ReadLine();
        Console.Write("Author: ");
            string author = Console.ReadLine();
        Console.Write("ReleaseDate: ");
            int releaseDate = int.Parse(Console.ReadLine());

            if (releaseDate < 1450 || releaseDate > 2021)
            {
                releaseDate = -1;
            }
            Book LORT = new Book(title, pages, category, author, releaseDate);
            Console.WriteLine($"{LORT.Title} {LORT.Pages} {LORT.Category} {LORT.Author} {LORT.ReleaseDate}");

        } 
    }
}
