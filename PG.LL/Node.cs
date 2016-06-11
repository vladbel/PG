using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.LL
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }


        #region "Find n-th element from the end"
        public static Node<T1> FindFromTail<T1>(Node<T1> head, int n)
        {
            var result = Node<T1>.FindFromTail<T1>(head, n, 0);
            return result.Item1;
        }
        private static Tuple<Node<T1>, int> FindFromTail<T1>(Node<T1> currentNode,
                                           int n,
                                           int currentNodeNumber)
        {

            if (currentNode.Next == null)
            {
                // we reach the end

                if (n == 0)
                    return new Tuple<Node<T1>, int>(currentNode, currentNodeNumber);
                else
                {
                    return new Tuple<Node<T1>, int>(null, currentNodeNumber); ;
                }
            }

            var result = FindFromTail(currentNode.Next, n, currentNodeNumber + 1);

            if (result.Item2 - currentNodeNumber == n)
            {
                return new Tuple<Node<T1>, int>(currentNode, result.Item2);
            }
            else
            {
                return result;
            }
        }


        #endregion

        #region "BuildListFromArray"
        
        public static Node<T1> Build<T1> (IEnumerable<T1> items)
        {
            Node<T1> head = null;
            Node<T1> current = null;

            foreach (var i in items )
            {
                
                if (head == null)
                {
                    head = new Node<T1>() { Value = i };
                    current = head;
                }
                else
                {
                    current.Next = new Node<T1>() { Value = i };
                    current = current.Next;
                }
            }

            return head;
        }
        #endregion
    }
}
