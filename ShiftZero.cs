using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Shift all zeros in the beginning of array/ Shift zeros at end
namespace ArrayDemo
{
    internal class ShiftZero
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 0, 8, 5, 2, 0, 0, 0, 5 };

            for (int i = arr.Length - 1; i > 0; i--)
            {
                int temp = 0;
                if (arr[i] == 0)
                    continue;
                else
                {
                    for (int j = 0; j < arr.Length && j < i; j++)
                    {
                        if (arr[j] == 0)
                        {
                            temp = arr[i];
                            arr[i] = arr[j];

                            arr[j] = temp;
                        }
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ,");
            }
        }
    }
}
