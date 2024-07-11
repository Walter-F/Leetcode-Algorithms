public class Solution {
    public int Reverse(int x) {
    int result = 0;
        while (x != 0) {
            int b = x % 10;
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && b > 7)) {
                return 0;
            }
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && b < -8)) {
                return 0;
            }
            result = result * 10 + b;
            x = x / 10;
        }
        return result;
    }
}