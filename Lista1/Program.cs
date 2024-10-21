using System;
using System.Collections.Generic;
namespace Lista1 {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}