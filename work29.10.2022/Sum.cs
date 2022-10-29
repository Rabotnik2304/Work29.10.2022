using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Sum
    {
        private uint left = 0;
        private uint right = 500;

        private uint countNumbers = 0;

        private uint SumDigits(uint number)
        {
            uint sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            return sum;
        }

        public uint GetCount()
        {
            for (uint i = left; i <= right; i++)
            {
                if (SumDigits(i) == 15)
                {
                    countNumbers += 1;
                }
            }

            return countNumbers;
        }
    }
}
