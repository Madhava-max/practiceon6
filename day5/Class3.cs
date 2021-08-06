using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    class Class3
    {
        public static void ReverseNumber(int num)
        {
            int rev = 0;
            while(num>0)
            {
                int reminder = num%10;
                
                rev = rev * 10 + reminder;
                
                num /= 10;
            }
            Console.WriteLine("the reversed number is " + rev);
        }
    }
}
