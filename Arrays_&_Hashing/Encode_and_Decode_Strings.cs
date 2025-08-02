public class Solution
{
    public string Encode(IList<string> strs)
    {
        return String.Join(",", strs);
    }

    public List<string> Decode(string s)
    {
        if (string.IsNullOrEmpty(s))
            return new List<string>();

        return s.Split(',').ToList();
    }

}
