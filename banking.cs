using System;
using System.Collections.Generic;
using System.Text;

namespace cash_counter_using_hashing
{
    class banking : bank
    {

        public int depositCash(int cash, int ubalance)//user deposit cash
        {

            ubalance += cash;
            return ubalance;
        }
        public int withdrawCash(int cash, int ubalance)//user withdraw cash
        {
            if (ubalance <= 0)
            {
                Console.WriteLine("cash is not available");
                return 0;
            }
            else
            {
                ubalance -= cash;
                return ubalance;
            }
        }

    }
}
