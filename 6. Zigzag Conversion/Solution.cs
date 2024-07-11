public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;

        List<StringBuilder> rows = new List<StringBuilder>(Math.Min(numRows, s.Length));
        for (int i = 0; i < Math.Min(numRows, s.Length); i++) {
            rows.Add(new StringBuilder());
        }

        int direction = -1;
        int currentRow = 0;

        foreach (char c in s) {
            rows[currentRow].Append(c);
            currentRow += (direction == -1) ? 1 : -1;

            if (currentRow == 0 || currentRow == numRows - 1) {
                direction = -direction;
            }
        }

        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows) {
            result.Append(row);
        }

        return result.ToString();
    }
}