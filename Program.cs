using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = new int[5] { 10, 20, 30, 40, 50 };
            float[] farr = {6.5f,8.3f,9.3f,8.2f,2.6f};
            string[] str = { "Pune", "Delhi", "Mumbai", "Ahemadnagar", "Gujarat" };

            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine($"arr[{i}]: {arr1[i]}");
            }
            for(int f=0;f<farr.Length;f++)
            {
                Console.WriteLine($"farr[{f}] : {farr[f]}");
            }
            for(int s=0;s<str.Length;s++)
            {
                Console.WriteLine($"str[{s}] : {str[s]}");
            }

            Console.WriteLine("------ForEachLoop------");
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }
            foreach(float f in farr)
            {
                Console.WriteLine(f);
            }
            foreach(string s in str)
            {
                Console.WriteLine(s);
            }
        }
    }
}
