using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            var radiok = new List<Radio>();
            using var sr = new StreamReader(
                path: @"..\..\..\src\cb.txt",
                encoding: System.Text.Encoding.UTF8
                
            );
            _ = sr.ReadLine();
            while (!sr.EndOfStream) radiok.Add(new(sr.ReadLine()));

            Console.WriteLine($"{radiok.Count}");
            Console.WriteLine();
            bool f3 = radiok.Any(h => h.adatsb == 4);
            Console.WriteLine($"{(f3 ? "volt": "nem volt")} 4 adadt werwqe ");
            Console.WriteLine("kerek egy nevdet");
            string knev = Console.ReadLine().ToLower();
            int f5 = radiok
                .Where(h => h.nev.ToLower() == knev.ToLower())
                .Sum(h => h.adatsb);
            if (f5 != 0) 
            {
                Console.WriteLine($"{knev}{f5} használta");
            }
            else
            {
                Console.WriteLine("nincs");
            }
            using var sw = new StreamWriter(
                path: @"..\..\..\src\asd.txt",
                append: false,
                encoding: System.Text.Encoding.UTF8
                );
            sw.WriteLine("Kezdes;nev;adatDb");
            foreach (var r in radiok)
            {
                sw.WriteLine($"{r.IdoPercben};{r.nev};{r.adatsb}");


                
            }
            int f8 = radiok.GroupBy(h => h.nev).Count();
            Console.WriteLine($"{f8}");
            Console.ReadLine();
        }
        
    }
}
