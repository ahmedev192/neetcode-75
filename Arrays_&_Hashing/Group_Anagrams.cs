// Solution for Group Anagrams
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            var key = string.Concat(word.OrderBy(c => c));
            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(word);
        }

        return map.Values.Cast<IList<string>>().ToList();
    }
}
