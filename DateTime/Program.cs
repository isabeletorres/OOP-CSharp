using System;
using System.Globalization;
namespace DataTempo {
    class Program {
        static void Main(string[] args) {
            
            DateTime d2 = new DateTime(2005, 10, 26);
            DateTime d3 = new DateTime(2005, 10, 26, 20, 45, 03);
            DateTime d4 = new DateTime(2005, 10, 26, 20, 45, 03, 500);

            DateTime d1 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2024-10-26");
            DateTime d8 = DateTime.Parse("2024-10-26 13:05:58");

            DateTime d10 = DateTime.ParseExact("2005-10-26", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d9 = DateTime.ParseExact("26/10/2005 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
        }
    }
}