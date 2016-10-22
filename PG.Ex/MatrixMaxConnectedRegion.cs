using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Ex
{
    public class MatrixMaxConnectedRegion
    {
        public static int ProcessMatrix( int[,] m)
        {
            const int IS_REGION = 1;
            var maxRegion = 0;

            for (var r = 0; r < m.GetLength(0); r++)
            {
                for (var c = 0; c < m.GetLength(1); c++)
                {
                    if (m[r,c] == IS_REGION)
                    {
                        maxRegion = Math.Max(maxRegion, TraverseRegion(m, new Tuple<int, int>(r, c)));
                    }
                }
            }

            return maxRegion;
        }

        public static int TraverseRegion (int[,] m, Tuple<int, int> e)
        {
            int result = 0;
            const int IS_REGION = 1;
            const int DISCOVERED = 2;
            const int VISITED = 3;

            var s = new Stack<Tuple<int, int>>();
            m[e.Item1, e.Item2] = DISCOVERED;
            s.Push(e);

            while ( s.Count > 0)
            {
                var cur = s.Pop();
                result++;
                var r = cur.Item1;
                var c = cur.Item2;
                m[r, c] = VISITED;

                // look for connected elements 
                // mark as discovered
                // push to stack
                for ( var rr = Math.Max(0, r - 1); rr < Math.Min (m.GetLength(0), r+1); rr++)
                {
                    for (var cc = Math.Max(0, c-1); cc < Math.Min(m.GetLength(1), c+1); cc++)
                    {
                        if (m[rr,cc] == IS_REGION)
                        {
                            m[rr, cc] = DISCOVERED;
                            s.Push(new Tuple<int, int>(rr, cc));
                        }
                    }
                }
           }

            return result;
        }
    }
}
