using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    internal class Solutions
    {

        //Binary search algorithm
        public double searchIndex(double[] array, double value)
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
            for (int i = 0; i < array.Length; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
