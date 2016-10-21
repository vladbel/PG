using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Ex
{
    public class LongestPairSequence
    {
        /// <summary>
        /// from https://www.hackerrank.com/challenges/two-characters
        /// String  always consists of two distinct alternating characters. For example, if string 's two distinct characters are 
        /// x and y, then t could be xyxyx or yxyxy but not xxyy or xyyx.
        ///You can convert some string to string by deleting characters from.
        ///When you delete a character from, you must delete all occurrences of it in .
        ///For example, if  abaacdabd and you delete the character a, then the string becomes bcdbd.

        ///Given , convert it to the longest possible string .
        ///Then print the length of string on a new line; if no string can be formed from , print instead.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int ProcessString(string s)
        {
            var d1 = new Dictionary<string, bool>(); //track possible first char
            var d2 = new Dictionary<string, string>(); //track "pair" strings

            for (var i = 0; i < s.Length; i++)
            {
                var cur = s[i].ToString();

                if (!d1.ContainsKey(cur))
                {
                    // case: ...a
                    // first occurence of 'a'
                    d1.Add(cur, true);
                }
                else
                {
                    //this is second occrence
                    d1[cur] = false;
                }

                foreach (KeyValuePair<string, bool> kv in d1)
                {
                    if (kv.Value == true 
                        && cur != kv.Key
                        && !(d1.ContainsKey(cur) && d1[cur] == false))
                    {
                        // ...a...b
                        // while d1['a'] is true we may form new pair 'ab'
                        if (!d2.ContainsKey(kv.Key + cur)
                            && !d2.ContainsKey(cur + kv.Key))
                        {
                            d2.Add(kv.Key + cur, kv.Key + cur);
                        }
                        else if (d2.ContainsKey(kv.Key + cur))
                        {
                            // case: a...b...b
                            // mark invalid invalid pair
                            d2[kv.Key + cur] = null;
                        }
                        else if (d2.ContainsKey(cur + kv.Key))
                        {
                            // a...b...a
                            if (d2[cur + kv.Key] != null && d2[cur + kv.Key].EndsWith(cur))
                            {
                                d2[cur + kv.Key] = null;
                            }
                            else if (d2[cur + kv.Key] != null)
                            {
                                d2[cur + kv.Key] += cur;
                            }
                        }
                    }
                    else if (kv.Key != cur)
                    {
                        string key = null;
                        if (d2.ContainsKey(kv.Key + cur) && d2.ContainsKey(cur + kv.Key))
                        {
                            // exception, we don't want this
                            throw new Exception("Duplicate keys");
                        }
                        else if (d2.ContainsKey(kv.Key + cur))
                        {
                            key = kv.Key + cur;
                        }
                        else if (d2.ContainsKey(cur + kv.Key))
                        {
                            key = cur + kv.Key;
                        }

                        if (key != null
                            && d2[key] != null
                            && !d2[key].EndsWith(cur))
                        {
                            d2[key] += cur;
                        }
                        else if (key != null
                                 && d2[key] != null
                                 && d2[key].EndsWith(cur))
                        {
                            d2[key] = null;
                        }
                    }
                }
            }

            int maxLength = 0;
            foreach (KeyValuePair<string, string> kv in d2)
            {
                if (kv.Value != null
                    && kv.Value.Length > maxLength)
                {
                    maxLength = kv.Value.Length;
                }
            }
            return maxLength;
        }
    }
}
