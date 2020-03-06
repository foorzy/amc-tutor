using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SandQuarry
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Console.ReadLine();
            var test1 = test.Split(new string[] { "-1" }, StringSplitOptions.RemoveEmptyEntries);
            int[] a1 = new int[test1[0].Length/2];
            string[] b1 = test1[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (var item in b1)
            {
                a1.SetValue(Convert.ToInt32(item), i);
                i++;
            }
            int z = 0;
            int[] a2 = new int[test1[1].Length/2];
            string[] b2 = test1[1].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item1 in b2)
            {
                a2.SetValue(Convert.ToInt32(item1), z);

                z++;
            }
            int time = a2[0];
            int res1 = ((int)(time / 2)) * a1[1];
            if (time < 2) res1 = 0;
            int res2 = ((int)(time / 5)) * a1[3]*20;
            if (time < 5) res2 = 0;
            int res3 = time * a1[5];
            int res = res1 + res2 + res3;
            Console.Write(res);
           
        }
    }
}
