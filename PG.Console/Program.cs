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
            Ex_1();
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
