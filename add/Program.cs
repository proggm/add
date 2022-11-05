using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int[10];
            Console.WriteLine($"Максимальное  число: {For(Generation(first))}");
            
            Console.ReadKey();
        }
        static int[] Generation(int[] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=random.Next(-50,50);
            }
            foreach (var item in arr)            
            {
                Console.WriteLine(item+"\t");
            }
            return arr;
        }
        static int For(int[] arr)
        {
            int first = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (first < arr[i])
                {
                    first = arr[i];                   
                }
            }
            return first;
        }
    }
}
