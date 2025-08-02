// Solution for Valid Anagram
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var charCounts = new Dictionary<char, int>();

        // Count characters in the first string
        foreach (char c in s)
        {
            if (!charCounts.ContainsKey(c))
                charCounts[c] = 1;
            else
                charCounts[c]++;
        }

        // Subtract counts using the second string
        foreach (char c in t)
        {
            if (!charCounts.ContainsKey(c))
                return false;

            charCounts[c]--;

            if (charCounts[c] < 0)
                return false;
        }

        // All counts should be zero at this point
        return true;
    }
}
