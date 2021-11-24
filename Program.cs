using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[10];
            Random rand = new Random();
            int N = arr.Length;
            for(int i = 0; i < N;i++)
            {
                arr[i] = rand.Next(0,3);
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == 0)
                {
                    N--;
                    for(int j = i; j < N; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[N] = -1;
                    i--;
                }
                   
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
