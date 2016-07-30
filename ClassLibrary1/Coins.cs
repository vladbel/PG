using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.DP
{
    public class Coins
    {
        public static Dictionary<int, int> Change_R ( int amount, 
                                                      int[] denominations, // assume anceding order
                                                      int startDenomination)
        {
            if (startDenomination < 0)
            {
                return null;
            }

            if ( startDenomination == 0 )
            {
              var change = amount / denominations[startDenomination];
              if (change * denominations[startDenomination] == amount)
                {
                    var res1 = new Dictionary<int, int>();
                    res1.Add(denominations[startDenomination], change);
                    return res1;
                }
                else
                {
                    return null;
                }
            }

            Dictionary<int, int> minResult = null;

            for (var i = 0; i <= amount/denominations[startDenomination]; i++)
            {
                var nextDenomination = startDenomination - 1;
                var result = Change_R(amount - denominations[startDenomination] * i,
                                       denominations,
                                       nextDenomination);

                if (result != null)
                {

                    result.Add(denominations[startDenomination], i);

                    if (minResult == null
                        || CountCoins(result) < CountCoins(minResult))
                    {
                        minResult = result;
                    }
                }

            }

            return minResult;
        }

        public static int CountCoins ( Dictionary<int, int> coins)
        {
            int count = 0;
            foreach ( var denomination in coins.Keys)
            {
                count += coins[denomination];
            }
            return count;
        }
    }
}
