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
            //==================================================================================================================================================================
            //firstDuplicate Given an array a that contains only numbers in the range from 1 to a.length, find the first duplicate number for which the second occurrence has the minimal index. In other words, if there are more than 1 duplicated numbers, return the number for which the second occurrence has a smaller index than the second occurrence of the other number does. If there are no such elements, return -1.


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
            result = 0;
            result = firstDuplicate1(ab);

            //Practice  ==================================================================================================================================================================

            int firstDuplicate2(int[] a)
            {
                HashSet<int> se = new HashSet<int>();
                foreach (var VARIABLE in a)
                {
                    if (se.Contains(VARIABLE))
                        return VARIABLE;
                    se.Add(VARIABLE);
                }

                return -1;
            }
            result = 0;
            result = firstDuplicate2(ab);

            //Practice 20210320  ==================================================================================================================================================================

            int firstDuplicate3(int[] a)
            {
                HashSet<int> hs = new HashSet<int>();

                foreach (var VARIABLE in a)
                {
                    if (hs.Contains(VARIABLE))
                        return VARIABLE;
                    hs.Add(VARIABLE);

                }
                return -1;
            }
            result = 0;
            result = firstDuplicate3(ab);


            int firstDuplicate7(int[] a)
            {
                HashSet<int> hs = new HashSet<int>();
                foreach (var VARIABLE in a)
                {
                    if (hs.Contains(VARIABLE))
                        return VARIABLE;
                    hs.Add(VARIABLE);
                }
                return - 1;
            }
            result = 0;
            result = firstDuplicate7(ab);


            int firstDuplicate8(int[] a)
            {
                HashSet<int> hs  = new HashSet<int>();
                foreach (var VARIABLE in hs)
                { 
                    if (hs.Contains(VARIABLE)) return VARIABLE;
                    hs.Add(VARIABLE);
                }
                return -1;
            }
            result = 0;
            result = firstDuplicate8(ab);



            //Practice 20210321  ==================================================================================================================================================================


            int firstDuplicate9(int[] a)
            {
                HashSet<int> hs = new HashSet<int>();
                foreach (int v in hs)
                {
                    if (hs.Contains(v)) return v;
                    hs.Add(v);
                }
                return -1;
            }
            result = 0;
            result = firstDuplicate9(ab);




            //==================================================================================================================================================================
            //firstNotRepeatingCharacter Given an array a that contains only numbers in the range from 1 to a.length, find the first duplicate number for which the second occurrence has the minimal index. In other words, if there are more than 1 duplicated numbers, return the number for which the second occurrence has a smaller index than the second occurrence of the other number does. If there are no such elements, return -1.


            string ss = "abacabad";

            char firstNotRepeatingCharacter(string s)
            {
                var exist = s.GroupBy(x => x).Where(x => x.Count() == 1).FirstOrDefault();
                return exist != null ? exist.Key : '_';
            }
            
           var result1 = firstNotRepeatingCharacter(ss);



            char firstNotRepeatingCharacter1(string s)
            {
                foreach (char c in s)
                {
                    if (s.IndexOf(c) == s.LastIndexOf(c))
                        return c;
                }
                return '_';
            }

            result1 = ' ';
            result1 = firstNotRepeatingCharacter1(ss);


        }
    }
}
