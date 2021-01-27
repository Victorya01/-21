using System;

class Program
{

    static void Main()
    {
        char[,] A = new char[5, 5];
        A[0, 0] = '*';
        A[1, 1] = '*';
        A[2, 2] = '*';
        A[3, 3] = '*';
        A[4, 4] = '*';

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {


                if (i == j)
                {
                    Console.Write(A[i, j]);
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }
    }

}

