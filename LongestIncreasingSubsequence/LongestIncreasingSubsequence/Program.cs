using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace LongestIncreasingSubsequence
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] parsedValues = Console.ReadLine().Split(' ');

            int arrayCount = Convert.ToInt32(parsedValues[0]);

            double[] values = new double[arrayCount];

            for (int i = 1; i < parsedValues.Length; i++)
            {
                values[i - 1] = Convert.ToInt32(parsedValues[i]);
            }


            int totalCount = 0;

            for (int i = 0; i < values.Length; i++)
            {

                int currentCount = 1;
                double currentElement = values[i];

                for (int j = 0; j < values.Length; j++)
                {
                    if (j > i)
                    {
                        if (values[j] > currentElement)
                        {
                            currentCount++;
                            currentElement = values[j];
                        }
                        else break;
                    }
                }

                if (currentCount > totalCount)
                {
                    totalCount = currentCount;
                }
            }
            Console.WriteLine(totalCount);
        }
       
    }
}

   

