public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string shortest = strs.OrderBy(s => s.Length).First();

        for (int i = 0; i < shortest.Length; i++)
        {
            if (strs.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];
        }

        return shortest;
    }
}