using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace Backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solutions solutions = new Solutions();

            double[] array = { 4, 5, 7, 11, 12, 15, 15, 21, 40, 45 };

            Console.WriteLine(solutions.searchIndex(array, 12));

            List<int> list = new List<int>() { 4, 5, 7, 11, 12, 15, 15, 21, 40, 45 };
            int item = 11;
            searchIndexList(list, item);

            //Czas
            getTime();

            int[] kkk = { 1, 2, 3, 4, 5, 6, 7, 8 };
            jumpByTwo(kkk);

            //Split string by new character
            var text = "line 1\nline 2";
            Console.WriteLine(text);


        }

        //Search Index
        public static void searchIndexList(List<int> list, int value)
        {
            int index = list.IndexOf(value);
            if (index!= -1)
            {
                Console.WriteLine(String.Format("Element {0} is found at index {1}", value, index));
            }
            else
            {
                Console.WriteLine("Element not found in the given list.");
            }
        }

        //Binary search algorithm
        public static double searchIndex(double[] array, double value)
        {
            double index = 0;
            double limit = array.Length - 1;

            while (index <= limit)
            {
                var sss = Math.Ceiling((index + limit) / 2);
                int point = (int)sss;
                var entry = array[point];

                if (value > entry)
                {
                    index = point + 1;
                    continue;
                }
                else if (value < entry)
                {
                    limit = point - 1;
                    continue;
                }
                return point;
            }
            return -1;
        }

        //Get global and local time
        public static void getTime()
        {
            Console.WriteLine("Global time is: " + DateTime.UtcNow.TimeOfDay);
            Console.WriteLine("Local time is: " + DateTime.Now.TimeOfDay);
        }


        //Utwórz array liste, przeliteruj usuwając co drugi element używając iteratora.
        public static void jumpByTwo(int[] array)
        {
            for (int i = 0; i < array.Length; i = i+2)
            {
                Console.WriteLine(i);
            }
        }
    }


}
