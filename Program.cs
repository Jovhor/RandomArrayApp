using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в создание двумерного массива!");
            Console.WriteLine("Введите количество строк:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение, до которого подбирать рандом:");
            int randy = int.Parse(Console.ReadLine());


            int[,] arr2d = new int[row, col];

            Random r = new Random();

            for (int i= 0; i < row; i++)
            {
                int sum = 0;

                for (int j = 0; j < col; j++)
                {
                    arr2d[i, j] = r.Next(randy+1);
                    sum += arr2d[i, j];
                    Console.Write($"{arr2d[i,j]} ");
                }
                Console.WriteLine($" : {sum}");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
