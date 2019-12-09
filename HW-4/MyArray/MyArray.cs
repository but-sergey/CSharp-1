using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    static public class MyArray
    {
        static public int[] Arr;

        static MyArray()
        {
            int dim = 10;
            int start = 0;
            int step = 1;

            Array.Resize(ref Arr, dim);

            Arr[0] = start;
            for (int i = 1; i < dim; i++)
            {
                Arr[i] = Arr[i - 1] + step;
            }
        }

        static public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < Arr.Length; i++)
                {
                    sum += Arr[i];
                }
                return sum;
            }
        }

        static public int MaxCount
        {
            get
            {
                int max = Arr[0];
                int count = 0;

                for (int i = 1; i < Arr.Length; i++)
                {
                    if (max < Arr[i])
                    {
                        max = Arr[i];
                        count = 1;
                    }
                    else
                    {
                        if (max == Arr[i])
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }

        static public int[] Inverse(int[] arr)
        {
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = -arr[i];
            }

            return newArr;
        }

        static public void Multi(int[] arr, int multimeter)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multimeter;
            }
        }

        static public int[] FillRandom(int count = 10, int min = 0, int max = 10)
        {
            int[] arr = new int[count];
            var rand = new Random();
            for (int i = 0; i < count; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }

        static public int[] FillFromFile(string fileName)
        {
            string[] FileLines = File.ReadAllLines(fileName);
            int[] arr = new int[FileLines.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(FileLines[i]);
            }
            return arr;
        }

        static public int ArrCountThree(int[] arr)
        {
            int counter = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int sumdiv = 0;

                sumdiv += (arr[i - 1] % 3 == 0) ? 1 : 0;
                sumdiv += (arr[i] % 3 == 0) ? 1 : 0;

                if (sumdiv == 1)
                {
                    counter++;
                }
            }

            return counter;
        }

        static public int ArrCountThree(int[] arr, ref int[] pairs)
        {
            int counter = ArrCountThree(arr);

            Array.Resize(ref pairs, counter);

            counter = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int sumdiv = 0;

                sumdiv += (arr[i - 1] % 3 == 0) ? 1 : 0;
                sumdiv += (arr[i] % 3 == 0) ? 1 : 0;

                if (sumdiv == 1)
                {
                    pairs[counter] = i - 1;
                    counter++;
                }
            }
            return counter;
        }

        static public string Print(int[] arr)
        {
            string toOut = "";
            for (int i = 0; i < arr.Length; i++)
            {
                toOut += $"{arr[i]}{((i == arr.Length - 1) ? "." : ", ")}";
            }
            return toOut;
        }

    }
}
