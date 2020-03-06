using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duplicates
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
            
       
            SortedSet<int> a2 = new SortedSet<int>();
            string[] b2 = test1[1].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item1 in b2)
            {
                a2.Add(Convert.ToInt32(item1));

            }
            for (int n = 0; n < a1.Length; n++)
            {
                Console.Write(a1[n]);
                Console.Write(" ");
                bool flag = false;
                for (int j = 0; j < a2.Count; j++)
                {
                 
                    foreach (var item in a2)
                    {
                        if (a1[n] == item)
                        {
                            Console.Write(a1[n]);
                            Console.Write(" ");
                            flag = true;
                            break;
                        }
                         
                    }
                    if (flag) break;
                }
            } 
                int konec = -1;
                Console.Write(konec);
            Console.ReadKey();
        
               
            
        }
    }
}
    

