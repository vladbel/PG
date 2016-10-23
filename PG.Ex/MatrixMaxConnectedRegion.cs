using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Ex
{
    /// <summary>
    /// from: https://www.hackerrank.com/challenges/connected-cell-in-a-grid
    /// Consider a matrix with  rows and  columns, where each cell contains either a 0 or a 0 and any
    /// cell containing a 1 is called a filled cell. Two cells are said to be connected if they are adjacent 
    /// to each other horizontally, vertically, or diagonally; and , provided that the location exists in the matrix for that .
    ///
    ///If one or more filled cells are also connected, they form a region.
    ///Note that each cell in a region is connected to at least one other cell in the region but is not necessarily 
    ///directly connected to all the other cells in the region.
    ///
    ///Task
    ///Given an matrix, find and print the number of cells in the largest region in the matrix.
    ///Note that there may be more than one region in the matrix.
    /// </summary>
    public class MatrixMaxConnectedRegion
    {
        public static int[,] ReadMatrix()
        {
            var rows = Int32.Parse(System.Console.ReadLine());
            var columns = Int32.Parse(System.Console.ReadLine());
            var matrix = new int[rows, columns];
            for (var i = 0; i < rows; i++)
            {
                var row = System.Console.ReadLine().Split(' ').Select(e => Int32.Parse(e)).ToArray();
                for (var j = 0; j < columns; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            return matrix;
        }

        public static void WriteMatrix(int[,] matrix)
        {
            for (var ri = 0; ri < matrix.GetLength(0); ri++)
            {
                var row = "";
                var delimiter = "";
                for (var ci = 0; ci < matrix.GetLength(1); ci++)
                {
                    row += delimiter + matrix[ri, ci].ToString();
                    delimiter = " ";
                }
                System.Console.WriteLine(row);
            }
        }

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

                // look for connected elements at 3x3 region (or 2x2 or 3x2 or 2x3 if border case)
                // mark as discovered
                // push to stack

                for ( var rr = Math.Max(0, r - 1); rr < Math.Min (m.GetLength(0), r+2); rr++) // made error here: was r+1 - index and length mixup
                {
                    for (var cc = Math.Max(0, c-1); cc < Math.Min(m.GetLength(1), c+2); cc++) // made error here: was c+1
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
