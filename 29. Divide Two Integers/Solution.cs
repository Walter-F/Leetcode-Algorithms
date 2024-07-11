public class Solution {
    public int Divide(int dividend, int divisor) {
        // Handle edge case
        if (dividend == int.MinValue && divisor == -1)
            return int.MaxValue;

        // check the result sign
        bool isNegative = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0);

        if (dividend > 0) dividend = -dividend;
        if (divisor > 0) divisor = -divisor;

        // exponational search
        int result = 0;
        while (dividend <= divisor) {
            int div = divisor, power = 1;
            while (dividend - div <= div) {
                div += div;
                power += power;
            }
            result += power;
            dividend -= div;
        }

        if (isNegative)
            return -result;
        return result;
    }
}