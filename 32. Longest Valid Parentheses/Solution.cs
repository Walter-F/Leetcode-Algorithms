public class Solution 
{
    public int LongestValidParentheses(string s) 
    {
        int left = 0;
        int right = 0;
        int longestParentheses = 0;

        for (int i = 0; i< s.Length; i++)
        {
            if (s[i] == '(')
            {
                left++;
            }
            else
            {
                right++;
            }

            if (left == right)
            {
                longestParentheses = Math.Max(longestParentheses, 2*left);
            }
            else if (right > left)
            {
                left = 0;
                right = 0;
            }
        }

        left = 0;
        right = 0;

        for (int i = s.Length - 1; i>=0; i--)
        {
            if (s[i] == ')')
            {
                right++;
            }
            else
            {
                left++;
            }

            if (left == right)
            {
                longestParentheses = Math.Max(longestParentheses, 2*right);
            }
            else if (left >= right)
            {
                left = 0;
                right = 0;
            }
        }
        

        return longestParentheses;
    }
}