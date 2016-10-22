using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Console
{
    class App
    {
        static void Main(string[] args)
        {
            var m = ReadMatrix();
            WriteMatrix(m);
            System.Console.ReadLine();
        }

        static int[,] ReadMatrix()
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

        static void WriteMatrix(int[,] matrix)
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


        /// <summary>
        ///  from: https://www.hackerrank.com/challenges/maximum-subarray-sum
        /// </summary>
        static void Ex_2()
        {
            var numberOfQueries = long.Parse(System.Console.ReadLine());
            for (var nq = 0; nq < numberOfQueries; nq++)
            {
                var firstInput = System.Console.ReadLine().Split(' ').Select(n => long.Parse(n)).ToArray();


                var size = (firstInput[0]);
                var modulo = (firstInput[1]);

                var array = System.Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

                var result = long.MinValue;

                var subArraySums = new long[array.Length];

                for (var i = 0; i < array.Length; i++)
                {
                    for (var j = 0; j <= i; j++)
                    {
                        subArraySums[j] = (subArraySums[j] + array[i] % modulo) % modulo;

                        if (subArraySums[j] > result)
                        {
                            result = subArraySums[j] % modulo;
                        }
                    }
                }

                System.Console.WriteLine(result.ToString());
            }
        }

        /// <summary>
        /// Find if array has element, so left sum = right sum
        /// </summary>
        static void Ex_1()
        {
            var numberOfTests = System.Console.ReadLine();
            var arrayLength = System.Console.ReadLine();
            var arrayString = System.Console.ReadLine();
            var array = arrayString.Split(" "[0]).Select(elem => int.Parse(elem)).ToArray();

            var rightSum = array.Sum();
            var result = "NO";
            var leftSum = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (leftSum == rightSum - array[i])
                {
                    result = "YES";
                    break;
                }
                leftSum += array[i];
                rightSum -= array[i];
            }

            System.Console.WriteLine(result);
            System.Console.WriteLine(leftSum.ToString() + " X " + rightSum.ToString());

            System.Console.ReadLine();
        }
    }
}
