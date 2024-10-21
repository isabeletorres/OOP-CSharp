
using System;
using System.Globalization;

namespace Foreach {
    class Program {
        static void Main(string[] args) {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            foreach (string str in vect) {
                Console.WriteLine(str);
            }
        }
    }
}
