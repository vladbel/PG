using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.DP
{
    public class RodCutting
    {
        private static int[] callCount;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length"></param>
        /// <param name="prices"></param>
        /// <param name="reset"></param>
        /// <returns>
        /// optimal Revenue
        /// call count
        /// cuts
        ///</returns>
        public static Tuple<int,int[], List<int>> Cut_Recurcive ( int length,
                                                                   int[] prices,
                                                                   bool reset)
        {
            if (reset)
            {
                callCount = new int[length + 1];
            }
            callCount[length]++;

            int maxRevenue = prices[length];
            List<int> cuts = new List<int>();

            if (length == 0)
            {
                return new Tuple<int, int[], List<int>>(prices[0],
                                                        callCount,
                                                        cuts);
            }
            else if (length == 1)
            {
                cuts = new List<int>();
                cuts.Add(1);
                return new Tuple<int, int[], List<int>>(prices[1],
                                                        callCount,
                                                        cuts);
            }
            else
            {
                cuts = new List<int>() { length };
            }

            for (var i = 1; i < length; i++)
            {
                var currentResult = Cut_Recurcive(length - i, prices, false);

                if (prices[i] + currentResult.Item1 > maxRevenue)
                {
                    maxRevenue = prices[i] + currentResult.Item1;
                    cuts = currentResult.Item3;
                    cuts.Add(i);
                }
            }

            var result = new Tuple<int, int[], List<int>>(maxRevenue, callCount, cuts);
            return result;
        }
    }
}
