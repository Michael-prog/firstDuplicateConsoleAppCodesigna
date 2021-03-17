using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodesigna
{
    class Program
    {
        static void Main(string[] args)
        {

           int[] ab  = {2, 1, 3, 5, 3, 2};

            int firstDuplicate(int[] a)
            {
                HashSet<int> se = new HashSet<int>();
                foreach (var t in a)
                {
                    if (se.Contains(t))
                        return t;
                    se.Add(t);
                }
                return -1;
            }

           var result =  firstDuplicate(ab);



           int firstDuplicate1(int[] a)
           {
               for (int i = 0; i < a.Length; i++)
               {
                   if (a[Math.Abs(a[i]) - 1] >= 0)
                       a[Math.Abs(a[i]) - 1] = -a[Math.Abs(a[i]) - 1];
                   else
                       return Math.Abs(a[i]);
               }
               return -1;
           }

           var result1 = firstDuplicate1(ab);

        }
    }
}
