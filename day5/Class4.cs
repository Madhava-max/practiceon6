using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    class Class4
    {
        public static void CouponNumber(int num)
        {
            int count = 0;
            Random rand = new Random();
            while(true)
            {
                int gen = rand.Next(0, num + 1);
                Console.WriteLine("  the gen is " + gen);
                if (gen==num)
                {
                    Console.WriteLine("the count is " + count);
                    break;
                }
                else
                {
                    count++;
                }
            }

            
        }
    }
}
