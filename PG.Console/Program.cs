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
            Ex_2();
            System.Console.ReadLine();
        }


        /// <summary>
        ///  from: https://www.hackerrank.com/challenges/maximum-subarray-sum
        /// </summary>
        static void Ex_2()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var firstInput = System.Console.ReadLine().Split(' ');
            var size = int.Parse(firstInput[0]);
            var modulo = int.Parse(firstInput[1]);
            var array = System.Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            var result = int.MinValue;

            var subArraySums = new int[size];
            var subArraySumModulos = new int[size];

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    subArraySums[j] += array[i];
                    subArraySumModulos[j] = subArraySums[j] % modulo;

                    if (subArraySumModulos[j] > result)
                    {
                        result = subArraySumModulos[j];
                    }
                }
            }

            System.Console.WriteLine(result.ToString());
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
