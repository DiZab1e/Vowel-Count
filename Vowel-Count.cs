using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        foreach (char d in str)
        {
            if (vowels.Contains(d))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}