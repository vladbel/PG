using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RodCutting
    {
        public static int Cut_Recurcive ( int length, int[] prices)
        {
            int maxRevenue = prices[length];

            if (length == 0)
            {
                return prices[0];
            }

            else if (length == 1)
            {
                return prices[1];
            }

            for (var i = 1; i < length; i++)
            {
                maxRevenue = Math.Max(maxRevenue, 
                    prices[i] + Cut_Recurcive(length - i, prices));
            }

            return maxRevenue;
        }
    }
}
