// Solution for Longest Substring Without Repeating Characters
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var unique = new HashSet<char>();
        int left = 0, right = 0, maxLength = 0;
        while (right < s.Length)
        {
            if (!unique.Contains(s[right]))
            {
                unique.Add(s[right++]);
                maxLength = Math.Max(maxLength, unique.Count);
            }
            else
            {
                unique.Remove(s[left++]);
            }
        }
        return maxLength;

    }
}