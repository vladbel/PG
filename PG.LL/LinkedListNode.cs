using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.LL
{
    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public static LinkedListNode<T> GetTail(LinkedListNode<T> head)
        {
            if (head.Next == null)
            {
                return head;
            }
            else
            {
                return GetTail(head.Next);
            }
        }


        #region "Find n-th element from the end"
        public static LinkedListNode<T> FindFromTail(LinkedListNode<T> head, int n)
        {
            var result = LinkedListNode<T>.FindFromTail(head, n, 0);
            return result.Item1;
        }
        private static Tuple<LinkedListNode<T>, int> FindFromTail(LinkedListNode<T> currentNode,
                                           int n,
                                           int currentNodeNumber)
        {

            if (currentNode.Next == null)
            {
                // we reach the end

                if (n == 0)
                    return new Tuple<LinkedListNode<T>, int>(currentNode, currentNodeNumber);
                else
                {
                    return new Tuple<LinkedListNode<T>, int>(null, currentNodeNumber); ;
                }
            }

            var result = FindFromTail(currentNode.Next, n, currentNodeNumber + 1);

            if (result.Item2 - currentNodeNumber == n)
            {
                return new Tuple<LinkedListNode<T>, int>(currentNode, result.Item2);
            }
            else
            {
                return result;
            }
        }


        #endregion

        #region "Build List From Array"
        
        public static LinkedListNode<T> Build(IEnumerable<T> items)
        {
            LinkedListNode<T> head = null;
            LinkedListNode<T> current = null;

            foreach (var i in items )
            {
                
                if (head == null)
                {
                    head = new LinkedListNode<T>() { Value = i };
                    current = head;
                }
                else
                {
                    current.Next = new LinkedListNode<T>() { Value = i };
                    current = current.Next;
                }
            }

            return head;
        }
        #endregion

        #region "Loop in list"

        public static LinkedListNode<T> FindLoopStart(LinkedListNode<T> head)
        {
            LinkedListNode<T> p1, p2;
            p1 = p2 = head;

            do
            {
                p1 = p1.Next;
                p2 = p2.Next.Next;
            } while (p1 != p2);

            p2 = head;

            while (p1 != p2)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p1;
        }

        #endregion
    }
}
