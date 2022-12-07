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
        var secretMapping = new Dictionary<char, int>();
        var cowsGuess = new List<char>();
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
                if (secretMapping.ContainsKey(secret[i]))
                {
                    secretMapping[secret[i]]++;
                }
                else
                {
                    secretMapping.Add(secret[i], 1);
                }

                cowsGuess.Add(guess[i]);
            }
        }

        foreach (var guessChar in cowsGuess)
        {
            if (secretMapping.ContainsKey(guessChar) && secretMapping[guessChar] != 0)
            {
                cows++;
                secretMapping[guessChar]--;
            }
        }
        
        return $"{bulls}A{cows}B";
    }
}