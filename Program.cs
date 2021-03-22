using System;
using System.CodeDom.Compiler;
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
            // Arrays 01  firstDuplicate Given an array a that contains only numbers in the range from 1 to a.length, find the first duplicate number for which the second occurrence has the minimal index. In other words, if there are more than 1 duplicated numbers, return the number for which the second occurrence has a smaller index than the second occurrence of the other number does. If there are no such elements, return -1.


            //==================================================================================================================================================================
            // V 01 

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




            //Practice  ==================================================================================================================================================================


   
            ab = new int[] { 2, 1, 3, 5, 3, 2 };


            int firstDuplicate2(int[] a)
            {
                HashSet<int> se = new HashSet<int>();
                foreach (var t in a)
                {
                    if (se.Contains(t)) return t;
                    se.Add(t);
                }

                return -1;
            }
            result = 0;
            result = firstDuplicate2(ab);

            //Practice 20210320  ==================================================================================================================================================================

            int firstDuplicate3(int[] a)
            {
                HashSet<int> se = new HashSet<int>();
                foreach (var t in a)
                {
                    if (se.Contains(t)) return t;
                    se.Add(t);

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
                    if (hs.Contains(VARIABLE)) return VARIABLE;
                    hs.Add(VARIABLE);
                }
                return - 1;
            }
            result = 0;
            result = firstDuplicate7(ab);


            int firstDuplicate8(int[] a)
            {
                HashSet<int> hs  = new HashSet<int>();
                foreach (var VARIABLE in a)
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
                foreach (int v in a)
                {
                    if (hs.Contains(v)) return v;
                    hs.Add(v);
                }
                return -1;
            }
            result = 0;
            result = firstDuplicate9(ab);



            //Practice 20210322  ==================================================================================================================================================================


            int firstDuplicate10(int[] a)
            {
                HashSet<int> hs = new HashSet<int>();
                foreach (int i in a)
                {
                    if (hs.Contains(i)) return i;
                    hs.Add(i);
                }

                return - 1;
            }
            result = 0;
            result = firstDuplicate10(ab);

            int firstDuplicate11(int[] a)
            {
                HashSet<int> hs = new HashSet<int>();
                foreach (var v in a)
                {
                    if (hs.Contains(v)) return v;
                    hs.Add(v);
                } 

                return -1;
            }
            result = 0;
            result = firstDuplicate11(ab);


            int firstDuplicate12(int []a)
            {
                HashSet<int> hs = new HashSet<int>();
                foreach (var V in a)
                {
                    if (hs.Contains(V))
                        return V;
                    hs.Add(V);
                }
                return -1;
            }
            result = 0;
            result = firstDuplicate12(ab);


            //==================================================================================================================================================================
            // V 02 

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





            //==================================================================================================================================================================
            // Arrays 02  firstNotRepeatingCharacter Given a string s consisting of small English letters, find and return the first instance of a non-repeating character in it. If there is no such character, return '_'.


            //==================================================================================================================================================================
            // V 01

            string ss = "abacabad";

            char firstNotRepeatingCharacter(string s)
            {
                var exist = s.GroupBy(x => x).Where(x => x.Count() == 1).FirstOrDefault();
                return exist != null ? exist.Key : '_';
            }
            
           var result1 = firstNotRepeatingCharacter(ss);





           //==================================================================================================================================================================
           // V 02

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







            //==================================================================================================================================================================
            // Linked Lists 01 removeKFromList  Try to solve this task in O(n) time using O(1) additional space, where n is the number of elements in the list, since this is what you'll be asked to do during an interview. Given a singly linked list of integers l and an integer k, remove all elements from list l that have a value equal to k.


            //https://stackoverflow.com/questions/49591213/why-is-linkedlistnode-next-property-readonly



            //LinkedListNode<int> removeKFromList1(LinkedListNode<int> l, int k)
            //{
            //    if (l?.Value == k)
            //    {
            //        l = removeKFromList(l?.Next, k);
            //    }
            //    if (l?.Next != null)
            //    {
            //        l.Next = removeKFromList(l?.Next, k);
            //    }
            //    return l;
            //}


            //LinkedListNode<int> removeKFromList(LinkedListNode<int> l, int k)
            //{
            //    var currNode = l;
            //    LinkedListNode<int> prevNode = null;

            //    while (null != currNode)
            //    {
            //        var nextNode = currNode.Next;
            //        if (k == currNode.Value)
            //        {
            //            if (null == prevNode)
            //            {
            //                l = nextNode;
            //            }
            //            else
            //            {
            //                prevNode.Next = nextNode;
            //            }
            //        }
            //        else
            //        {
            //            prevNode = currNode;
            //        }

            //        currNode = nextNode;
            //    }

            //    return l;
            //}





            //List<int> la = new List<int>() { 3, 1, 2, 3, 4, 5 };


            //bool isListPalindrome(LinkedListNode<int> l)
            //{
            //    Dictionary<int, int> listPos = new Dictionary<int, int>();
            //    LinkedListNode<int> current = l;
            //    int pos = 0;
            //    while (current != null)
            //    {
            //        listPos.Add(pos, current.Value);
            //        current = current.Next;
            //        pos++;
            //    }
            //    for (int i = 0; i < pos / 2; i++)
            //    {
            //        if (listPos[i] != listPos[pos - i - 1])
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}

            //isListPalindrome(la);



        }
    }
}
