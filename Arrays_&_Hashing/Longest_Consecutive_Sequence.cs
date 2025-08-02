public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> numbers = new(nums);
        int longestSequence = 0;

        foreach (int num in numbers)
        {
            if (!numbers.Contains(num - 1))
            {
                int currentNum = num;
                int currentLength = 1;

                while (numbers.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentLength++;
                }

                longestSequence = Math.Max(longestSequence, currentLength);
            }
        }

        return longestSequence;
    }
}