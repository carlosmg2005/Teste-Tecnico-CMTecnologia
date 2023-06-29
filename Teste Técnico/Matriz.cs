using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Técnico
{
    public class Matriz
    {
        private int[,] matriz;

        public Matriz(int[,] matriz)
        {
            this.matriz = matriz;
        }

        public void InverterDiagonais()
        {
            int tamanho = matriz.GetLength(0);

            for (int i = 0; i < tamanho / 2; i++)
            {
                // Inverter a diagonal principal
                TrocarElementos(i, i, tamanho - i - 1, tamanho - i - 1);

                // Inverter a diagonal secundária
                TrocarElementos(i, tamanho - i - 1, tamanho - i - 1, i);
            }
        }

        private void TrocarElementos(int i1, int j1, int i2, int j2)
        {
            int temp = matriz[i1, j1];
            matriz[i1, j1] = matriz[i2, j2];
            matriz[i2, j2] = temp;
        }

        public void ImprimirMatriz()
        {
            int tamanho = matriz.GetLength(0);

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int ContarSubmatriz(int[,] submatriz)
        {
            int count = 0;
            int rowsA = matriz.GetLength(0);
            int colsA = matriz.GetLength(1);
            int rowsB = submatriz.GetLength(0);
            int colsB = submatriz.GetLength(1);

            for (int i = 0; i <= rowsA - rowsB; i++)
            {
                for (int j = 0; j <= colsA - colsB; j++)
                {
                    if (VerificarSubmatriz(i, j, submatriz))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private bool VerificarSubmatriz(int startRow, int startCol, int[,] submatriz)
        {
            int rowsB = submatriz.GetLength(0);
            int colsB = submatriz.GetLength(1);

            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    if (matriz[startRow + i, startCol + j] != submatriz[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
