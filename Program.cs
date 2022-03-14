using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios15
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int nFilas, nCol,sumaFilas,sumaCol;
            Console.Write("Digite el numero de Filas: ");
            nFilas= int.Parse(Console.ReadLine());
            Console.Write("Digite el numero de Columnas: ");
            nCol= int.Parse(Console.ReadLine());
           int [,] matriz=new int[nFilas,nCol];
            Console.WriteLine("Digite la matriz: ");
            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write("matriz[" + i + "][" + j + "]: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La matriz es: ");
            for (int i = 0; i < nFilas; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 0; i < nFilas; i++)
            {
                sumaFilas = 0;
                for (int j = 0; j < nCol; j++)
                {
                    sumaFilas+=matriz   [i,j];
                }
                Console.WriteLine("la suma de la fila[" + i + "] es : "+sumaFilas);
            }
            Console.WriteLine("");
            for (int j = 0; j < nCol; j++)
            {
                sumaCol = 0;
                for (int i = 0; i < nFilas; i++)
                {
                    sumaCol+=matriz [i,j];
                }
                Console.WriteLine("La suma de la columna [" + j + "] es :" + sumaCol);
            }
            Console.WriteLine("");
        }

    }
}