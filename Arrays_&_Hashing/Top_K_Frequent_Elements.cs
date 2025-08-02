// Solution for Valid Anagram
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> occurance = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!occurance.ContainsKey(num))
                occurance[num] = 0;

            occurance[num]++;
        }

        // Build the most frequent values list dynamically and take top k
        var mostFrequentValues = occurance
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();

        return mostFrequentValues;
    }

}
