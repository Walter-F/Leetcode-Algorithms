public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        int i = 0, num = 0, sign = 1;

        if (s[0] == '+' || s[0] == '-') {
            sign = (s[0] == '-') ? -1 : 1;
            i++;
        }

        while (i < s.Length && Char.IsDigit(s[i])) {
            int digit = s[i] - '0';
            if (num > (Int32.MaxValue - digit) / 10) {
                return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
            }
            num = num * 10 + digit;
            i++;
        }

        return sign * num;
    }
}