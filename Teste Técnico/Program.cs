using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Técnico
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = 
        {
            {0, 1, 2, 3, 4},
            {5, 6, 7, 8, 9},
            {0, 1, 2, 3, 4},
            {5, 6, 7, 8, 9},
            {0, 1, 2, 3, 4}
        };
            int[,] submatriz = 
        {
            {2, 3},
            {7, 6}
        };

            Matriz minhaMatriz = new Matriz(matriz);
            Console.WriteLine("Matriz original:");
            minhaMatriz.ImprimirMatriz();
            Console.ReadLine();

            minhaMatriz.InverterDiagonais();
            Console.WriteLine("Matriz com diagonais invertidas:");
            minhaMatriz.ImprimirMatriz();
            Console.ReadLine();

            Console.WriteLine("Submatriz B:");
            Matriz subMatriz = new Matriz(submatriz);
            subMatriz.ImprimirMatriz();
            Console.ReadLine();

            int count = minhaMatriz.ContarSubmatriz(submatriz);
            Console.WriteLine("A submatriz B pode ser encontrada {0} vezes na matriz A.", count);
            Console.ReadLine();
        }
    }
}
