using System;

namespace ArrayFull
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Массив:");

            Random r = new Random();
            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = r.Next(100);

                    Console.Write(arr[i, j] + "   ");
                }
                Console.WriteLine("\n");
            }

            int[,] arrCopy = arr;
            

            Console.WriteLine("Повторяющиеся:");
            for (int i = 0; i < 10; i++)
            {                
                for (int j = 0; j < 10; j++)
                {                    
                    for (int k = i; k < 10; k++)
                    {
                        for (int l = j + 1; l < 10; l++) 
                        {
                            if (arr[i,j] == arr [k,l])
                            {
                                arr[k, l] = 0; 
                            }
                        }
                    }
                }
            }                       

            Console.ReadLine();
        }
    }
}
