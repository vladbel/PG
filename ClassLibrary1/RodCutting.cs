using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.DP
{
    public class RodCutting
    {
        private static int[] _callCount;

        private static Dictionary<int, Tuple<int, int[], List<int>>> _cuts;

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
                _callCount = new int[length + 1];
            }
            _callCount[length]++;

            int maxRevenue = prices[length];
            List<int> cuts = new List<int>();

            if (length == 0)
            {
                return new Tuple<int, int[], List<int>>(prices[0],
                                                        _callCount,
                                                        cuts);
            }
            else if (length == 1)
            {
                cuts = new List<int>();
                cuts.Add(1);
                return new Tuple<int, int[], List<int>>(prices[1],
                                                        _callCount,
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

            var result = new Tuple<int, int[], List<int>>(maxRevenue, _callCount, cuts);
            return result;
        }



        /// <summary>
        /// Top Down implementation ( modifyed recurcive)
        /// </summary>
        /// <param name="length"></param>
        /// <param name="prices"></param>
        /// <param name="reset"></param>
        /// <returns>
        /// optimal Revenue
        /// call count
        /// cuts
        ///</returns>
        public static Tuple<int, int[], List<int>> Cut_DP1(int length,
                                                                   int[] prices,
                                                                   bool reset)
        {
            if (reset)
            {
                _callCount = new int[length + 1];
                _cuts = new Dictionary<int, Tuple<int, int[], List<int>>>();
            }
            _callCount[length]++;

            int maxRevenue = prices[length];
            List<int> cuts = new List<int>();

             if (length == 1)
            {
                cuts.Add(1);
                _cuts.Add (1,  new Tuple<int, int[], List<int>>(prices[1],
                                                        _callCount,
                                                        cuts));
                return _cuts[1];
            }
            else
            {
                cuts = new List<int>() { length };
            }

            for (var i = 1; i < length; i++)
            {
                Tuple<int, int[], List<int>> currentResult;
                if (!_cuts.ContainsKey(length - i))
                {
                    currentResult = Cut_DP1(length - i, prices, false);
                }
                else
                {
                    currentResult = _cuts[length - i];
                }

                if (prices[i] + currentResult.Item1 > maxRevenue)
                {
                    maxRevenue = prices[i] + currentResult.Item1;
                    cuts = new List<int>();
                    cuts.AddRange(currentResult.Item3);
                    cuts.Add(i);
                }
            }

            var result = new Tuple<int, int[], List<int>>(maxRevenue, 
                                                         _callCount, 
                                                          cuts);
            _cuts.Add(length, result);
            return result;
        }


        public static Tuple<int, int[], List<int>> Cut_DP2_BottomUp(int length,
                                                           int[] prices,
                                                           bool reset)
        {
            if (reset)
            {
                _callCount = new int[length + 1];
                _cuts = new Dictionary<int, Tuple<int, int[], List<int>>>();
                _cuts.Add (0, new Tuple<int, int[], List<int>>(0,
                                                               new int[]{ },
                                                               new List<int>()));
            }
            _callCount[length]++;



            for ( var i = 1; i <= length; i ++)
            {
                Tuple<int, int[], List<int>> currentResult = null;

                for (var j = 1; j <= i; j++)
                {
                    if ( currentResult == null 
                        ||prices[j] + _cuts[i - j].Item1 > currentResult.Item1)
                    {
                        var newCuts = new List<int>(_cuts[i - j].Item3);
                        newCuts.Add(j);
                        currentResult = new Tuple<int, int[], List<int>>(prices[j] + _cuts[i - j].Item1,
                                                                            null, newCuts);
                    }
                }
                _cuts.Add(i, currentResult);
            }

            return _cuts[length];
        }
    }
}
