using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata6.AnagramClasses
{
    public class AnagramChecker
    {


        public bool CheckAnagram(char[] baseValue, char[] toCompareValue)
        {
            Array.Sort(baseValue);
            Array.Sort(toCompareValue);

            string baseSorted = String.Join("", baseValue).ToLower();
            string toCompareSorted = String.Join("", toCompareValue).ToLower();

            if (baseSorted == toCompareSorted)
                return true;

            return false;
        }
    }
}
