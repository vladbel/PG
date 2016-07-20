using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.DP
{
    public class RodCutting
    {
        public static Tuple<int, int, List<int>> Cut_Recurcive ( int length, int[] prices)
        {
            int maxRevenue = int.MinValue;
            List<int> cuts = null;

            if (length == 0)
            {
                return new Tuple<int, int, List<int>>(prices[0], 0, new List<int>());
            }

            else if (length == 1)
            {
                cuts = new List<int>();
                cuts.Add(1);
                return new Tuple<int, int, List<int>>(prices[1], 0, cuts);
            }

            for (var i = 1; i < length; i++)
            {
                var currentResult = Cut_Recurcive(length - i, prices);

                if (prices[i] + currentResult.Item1 > maxRevenue)
                {
                    maxRevenue = prices[i] + currentResult.Item1;
                    cuts = new List<int>();
                    cuts.AddRange(currentResult.Item3);
                    cuts.Add(i);
                }
                
            }

            var result = new Tuple<int, int, List<int>>(maxRevenue, 0, cuts);
            return result;
        }
    }
}
