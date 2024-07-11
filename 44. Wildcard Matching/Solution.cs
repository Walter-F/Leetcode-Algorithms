public class Solution
{
    public bool IsMatch(string s, string p)
    {
        var i = 0;
        var j = 0;
        var star = -1;
        var m = -1;

        while (i < s.Length)
        {
            if (j < p.Length && (p[j] == '?' || p[j] == s[i]))
            {
                i++;
                j++;

                continue;
            }

            if (j < p.Length && p[j] == '*')
            {
                star = j++;
                m = i;

                continue;
            }

            if (star >= 0)
            {
                j = star + 1;
                i = ++m;

                continue;
            }

            return false;
        }

        while (j < p.Length && p[j] == '*')
        {
            j++;
        }

        return j == p.Length;
    }
}