using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.LL
{
    public class LinkedList<T>
    {
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

        public static LinkedListNode<T> Reverse(LinkedListNode<T> head)
        {
            LinkedListNode<T> previous = null;

            while (head != null)
            {
                var nextNode = head.Next;
                head.Next = previous;
                if (nextNode == null)
                {
                    break;
                }
                previous = head;
                head = nextNode;
            }

            return head;
        }


        #region "Find n-th element from the end"
        public static LinkedListNode<T> FindFromTail(LinkedListNode<T> head, int n)
        {
            var result = LinkedList<T>.FindFromTail(head, n, 0);
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

            foreach (var i in items)
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

        #region Find Value
        public static LinkedListNode<T> Find (LinkedListNode<T> head, T value)
        {
            do
            {
                if (head.Value.Equals(value))
                {
                    return head;
                }
                head = head.Next;
            } while (head != null);

            return null;
        }
        #endregion

        #region Ariphmetic ops
        public static LinkedListNode<int> Add(LinkedListNode<int> head1, LinkedListNode<int> head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            else if (head2 == null)
            {
                return head1;
            }

            int carry = 0;
            LinkedListNode<int> result = null;
            LinkedListNode<int> resultCurrent = null;

            while (head1 != null || head2 != null || carry > 0)
            {
                if (head1 == null && head2 == null && carry == 0)
                {
                    break;
                }

                var val1 = (head1 == null ? 0 : head1.Value);
                var val2 = (head2 == null ? 0 : head2.Value);
                var intResult = val1 + val2 + carry;

                var newNode = new LinkedListNode<int>();
                newNode.Value = intResult % 10;
                carry = intResult / 10;

                if (result == null)
                {
                    result = resultCurrent = newNode;
                }
                else
                {
                    resultCurrent.Next = newNode;
                    resultCurrent = newNode;
                }

                if (head1 != null)
                {
                    head1 = head1.Next;
                }
                if (head2 != null)
                {
                    head2 = head2.Next;
                }

            }
            return result;
        }

        public static LinkedListNode<int> Multiply (LinkedListNode<int> head, int num, int shift = 0)
        {
            int carry = 0;

            LinkedListNode<int> resultHead = null;
            LinkedListNode<int> currentResultNode = null;


            for (var i = 0; i < shift; i++)
            {
                if (currentResultNode == null)
                {
                    resultHead = currentResultNode = new LinkedListNode<int>();
                }
                else
                {
                    currentResultNode.Next = new LinkedListNode<int>();
                    currentResultNode = currentResultNode.Next;
                }
                currentResultNode.Value = 0;
            }

            while (head != null ||  carry > 0)
            {
                if (currentResultNode == null)
                {
                    resultHead = currentResultNode = new LinkedListNode<int>();
                }
                else
                {
                    currentResultNode.Next = new LinkedListNode<int>();
                    currentResultNode = currentResultNode.Next;
                }

                var currentValue = (head == null ? 0 : head.Value);
                var tempResult = currentValue * num + carry;
                currentResultNode.Value = tempResult % 10;
                carry = tempResult / 10;

                if (head != null)
                {
                    head = head.Next;
                }
            }

            return resultHead;
        }


        public static LinkedListNode<int> Multiply (LinkedListNode<int> lst_1, LinkedListNode<int> lst_2)
        {
            LinkedListNode<int> result = null;
            int shift = 0;

            while ( lst_2 != null)
            {
                var temp = LinkedList<int>.Multiply(lst_1, lst_2.Value, shift);
                result = LinkedList<int>.Add(result, temp);

                lst_2 = lst_2.Next;
                shift++;
            }

            return result;
        }

        #endregion


        public static LinkedListNode<int> Merge(LinkedListNode<int> head1, LinkedListNode<int> head2)
        {
            LinkedListNode<int> head = null;
            LinkedListNode<int> runner = null;

            if (head1 == null)
            {
                return head2;
            }

            if (head2 == null)
            {
                return head1;
            }

            if (head1.Value > head2.Value)
            {
                head = runner = head2;
                head2 = head2.Next;
            }
            else
            {
                head = runner = head1;
                head1 = head1.Next;
            }

            while (head1 != null || head2 != null)
            {
                while (head1 != null && head2 != null && head1.Value <= head2.Value)
                {
                    runner.Next = head1;
                    runner = head1;
                    head1 = head1.Next;
                }

                while (head1 != null && head2 == null)
                {
                    runner.Next = head1;
                    runner = head1;
                    head1 = head1.Next;
                }

                while (head1 != null && head2 != null && head1.Value >= head2.Value)
                {
                    runner.Next = head2;
                    runner = head2;
                    head2 = head2.Next;
                }

                while (head1 == null && head2 != null)
                {
                    runner.Next = head2;
                    runner = head2;
                    head2 = head2.Next;
                }
            }

            return head;
        }
    }
}