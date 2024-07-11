public class Solution 
{
    public string CountAndSay(int n) 
    {
        if (n == 1) return "1";
        else return Say(CountAndSay(n - 1));

        string Say(string s)
        {
            int n = s.Length;
            StringBuilder res = new();
            int currentCount = 0;
            for (int i = 0; i < n - 1; i++)
            {
                currentCount++;
                if (s[i] != s[i + 1])
                {
                    res.Append(currentCount.ToString());
                    res.Append(s[i].ToString());
                    currentCount = 0;
                }
            }
            currentCount++;
            res.Append(currentCount.ToString());
            res.Append(s[n - 1].ToString());
            return res.ToString();
        }
    }
}