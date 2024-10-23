using System;

namespace MatrizExercice2 {
    class Program {
        static void Main(string[] args) {

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int j =0; j<n; j++) {
                    matriz[i,j] = int.Parse(values[j]);
                }
            }
            int numAleatorio = int.Parse(Console.ReadLine());

            for (int i=0; i<m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matriz[i, j] == numAleatorio) {
                        Console.WriteLine($"Position {i}, {j}:");
                        if (j>0) {
                            Console.WriteLine($"Left: {matriz[i, j-1]}");
                        }  
                        if (i > 0) {
                            Console.WriteLine($"Up: {matriz[i-1, j]}");
                        }
                        if (j<n-1) {
                            Console.WriteLine($"Right: {matriz[i, j+1]}");
                        }
                        if (i < m - 1) {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
