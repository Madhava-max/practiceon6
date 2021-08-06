using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    class Class1
    {
        public static void CheckifPerfectNumber(int num)
        {
            int each = 0;
            for(int i=1;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    each += i;
                }
            }
            if(each==num)
            {
                Console.WriteLine("the given number is perfect");
            }
            else
            {
                Console.WriteLine("the given number is not perfect");
            }
        }
    }
}
