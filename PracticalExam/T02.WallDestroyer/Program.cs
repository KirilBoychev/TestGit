using System;

namespace T02.WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n,n];

            int rowVanco = 0;
            int colVanco = 0;

            int holesCount = 0;
            int rodCount = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'V')
                    {
                        rowVanco = rows;
                        colVanco = cols;
                    }
                }
            }

            bool flag = false;

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "up")
                {
                    if (rowVanco - 1 < 0)
                    {
                        continue;
                    }
                    if (matrix[rowVanco - 1, colVanco] == 'R')
                    {
                        rodCount++;
                        Console.WriteLine($"Vanko hit a rod!");
                        continue;
                    }
                    else if (matrix[rowVanco - 1, colVanco] == 'C')
                    {
                        matrix[rowVanco, colVanco] = '*';
                        matrix[rowVanco - 1, colVanco] = 'E';
                        holesCount = NewMethod(matrix, ref holesCount);
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
                        flag = true;
                        break;
                    }
                    else if (matrix[rowVanco - 1, colVanco] == '*')
                    {
                        matrix[rowVanco, colVanco] = '*';
                        rowVanco--;
                        matrix[rowVanco, colVanco] = 'V';
                        Console.WriteLine($"The wall is already destroyed at position [{rowVanco}, {colVanco}]!");
                    }
                    else
                    {
                        matrix[rowVanco, colVanco] = '*';
                        rowVanco--;
                        matrix[rowVanco, colVanco] = 'V';
                    }
                }
                else if (command == "down")
                {
                    if (rowVanco + 1 > matrix.GetLength(0) - 1)
                    {
                        continue;
                    }
                    if (matrix[rowVanco + 1, colVanco] == 'R')
                    {
                        rodCount++;
                        Console.WriteLine($"Vanko hit a rod!");
                        continue;
                    }
                    else if (matrix[rowVanco + 1, colVanco] == 'C')
                    {
                        matrix[rowVanco, colVanco] = '*';
                        matrix[rowVanco + 1, colVanco] = 'E';
                        holesCount = NewMethod(matrix, ref holesCount);
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
                        flag = true;
                        break;
                    }
                    else if (matrix[rowVanco + 1, colVanco] == '*')
                    {
                        matrix[rowVanco, colVanco] = '*';
                        rowVanco++;
                        matrix[rowVanco, colVanco] = 'V';
                        Console.WriteLine($"The wall is already destroyed at position [{rowVanco}, {colVanco}]!");
                    }
                    else
                    {
                        matrix[rowVanco, colVanco] = '*';
                        rowVanco++;
                        matrix[rowVanco, colVanco] = 'V';
                    }
                }
                else if (command == "left")
                {
                    if (colVanco - 1 < 0)
                    {
                        continue;
                    }
                    if (matrix[rowVanco, colVanco - 1] == 'R')
                    {
                        rodCount++;
                        Console.WriteLine($"Vanko hit a rod!");
                        continue;
                    }
                    else if (matrix[rowVanco, colVanco - 1] == 'C')
                    {
                        matrix[rowVanco, colVanco] = '*';
                        matrix[rowVanco, colVanco - 1] = 'E';
                        holesCount = NewMethod(matrix, ref holesCount);
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
                        flag = true;
                        break;
                    }
                    else if (matrix[rowVanco, colVanco - 1] == '*')
                    {
                        matrix[rowVanco, colVanco] = '*';
                        colVanco--;
                        matrix[rowVanco, colVanco] = 'V';
                        Console.WriteLine($"The wall is already destroyed at position [{rowVanco}, {colVanco}]!");
                    }
                    else
                    {
                        matrix[rowVanco, colVanco] = '*';
                        colVanco--;
                        matrix[rowVanco, colVanco] = 'V';
                    }
                }
                else if (command == "right")
                {
                    if (colVanco + 1 > matrix.GetLength(1) - 1)
                    {
                        continue;
                    }
                    if (matrix[rowVanco, colVanco + 1] == 'R')
                    {
                        rodCount++;
                        Console.WriteLine($"Vanko hit a rod!");
                        continue;
                    }
                    else if (matrix[rowVanco, colVanco + 1] == 'C')
                    {
                        matrix[rowVanco, colVanco] = '*';
                        matrix[rowVanco, colVanco + 1] = 'E';
                        holesCount = NewMethod(matrix, ref holesCount);
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesCount} hole(s).");
                        flag = true;
                        break;
                    }
                    else if (matrix[rowVanco, colVanco + 1] == '*')
                    {
                        matrix[rowVanco, colVanco] = '*';
                        colVanco++;
                        matrix[rowVanco, colVanco] = 'V';
                        Console.WriteLine($"The wall is already destroyed at position [{rowVanco}, {colVanco}]!");
                    }
                    else
                    {
                        matrix[rowVanco, colVanco] = '*';
                        colVanco++;
                        matrix[rowVanco, colVanco] = 'V';
                    }
                }
            }

            if (flag == false)
            {
                holesCount = SecondMethod(matrix, ref holesCount);
                Console.WriteLine($"Vanko managed to make {holesCount} hole(s) and he hit only {rodCount} rod(s).");
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows,cols]);
                }
                Console.WriteLine();
            }
        }

        private static int NewMethod(char[,] matrix, ref int holesCount)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '*' || matrix[i, j] == 'E')
                    {
                        holesCount++;
                    }
                }
            }

            return holesCount;
        }

        private static int SecondMethod(char[,] matrix, ref int holesCount)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '*' || matrix[i, j] == 'V')
                    {
                        holesCount++;
                    }
                }
            }

            return holesCount;
        }
    }
}
