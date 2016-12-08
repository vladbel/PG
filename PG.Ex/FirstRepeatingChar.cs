using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Ex
{
    public class FirstRepeatingChar
    {
        public static char GetFirstChar(string str)
        {
            if (str == null || str.Length == 0)
            {
                throw new ArgumentException();
            }
            var flags = Enumerable.Repeat(-1, 256).ToArray();


            int firstPosition = int.MaxValue;

            for (var i = 0; i < str.Length; i++)
            {
                if (flags[(int)str[i]] >= 0)
                {
                    if (flags[(int)str[i]] < firstPosition) // A
                    {
                        firstPosition = i; // 2[C} -> 1[B]
                    }
                }
                else
                {
                    flags[(int)str[i]] = i; // [ .....0[A],1[B],2[C].....]
                }
            }

            return str[firstPosition]; // ??

        }
    }
}
