// Solution for Valid Palindrome
public class Solution
{
    public bool IsPalindrome(string s)
    {
        var cleaned = new string(
            s.ToLower().Where(char.IsLetterOrDigit).ToArray()
        );

        int left = 0, right = cleaned.Length - 1;

        while (left < right)
        {
            if (cleaned[left++] != cleaned[right--])
                return false;
        }

        return true;
    }
}
