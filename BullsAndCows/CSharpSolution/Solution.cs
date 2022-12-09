using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSolution;

public class Solution
{
    public string GetHint(string secret, string guess)
    {
        var h = new int[10];
        var bulls = 0;
        var cows = 0;

        for (var i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
            {
                bulls++;
            }
            else
            {
                if (h[secret[i] - '0'] < 0)
                {
                    cows++;
                }

                if (h[guess[i] - '0'] > 0)
                {
                    cows++;
                }

                h[secret[i] - '0']++;
                h[guess[i] - '0']--;
                
            }
        }

        return $"{bulls}A{cows}B";
    }
}