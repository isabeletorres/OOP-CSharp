﻿using course;
using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args){
            
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();    

            Console.WriteLine($"Área de x= {areaX:F4}");
            Console.WriteLine($"Área de x= {areaY:F4}");

            if (areaX > areaY) {
                Console.WriteLine("Mior área: X");
            } else if (areaY> areaX) {
                Console.WriteLine("Mior área: y");
            } else {
                Console.WriteLine("As áreas são iguais");
            }
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("NOme: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else if (p2.Idade > p1.Idade) {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }
            else {
                Console.WriteLine($"{p1.Nome} e {p2.Nome} tem a mesma idade");
            }

            Funcionario funcionario = new Funcionario();
            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("Dados do 1° fucionario ");
            Console.WriteLine("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do 2° funcionario");
            Console.WriteLine("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario.Salario + funcionario1.Salario) / 2;
            Console.WriteLine("Salario medio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

