using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpSolution;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var min = int.MaxValue;
        var profit = 0;
        foreach (var price in prices)
        {
            if (price < min)
            {
                min = price;
            }
            
            var calculateProfit = price - min;
            
            if (calculateProfit > profit)
            {
                profit = calculateProfit;
            }
        }

        return profit;
    }
}