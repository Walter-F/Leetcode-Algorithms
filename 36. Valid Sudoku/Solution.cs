public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            HashSet<char> row = new();
            HashSet<char> column = new();
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != '.' && !row.Add(board[i][j])) return false;
                if (board[j][i] != '.' && !column.Add(board[j][i])) return false;
            }
        }

        for (int k = 0; k < 9; k++)
        {
            HashSet<char> box = new();
            int boxRow = k / 3 * 3;
            int boxCol = k % 3 * 3;
            for (int i = boxRow; i < boxRow + 3; i++)
            {
                for (int j = boxCol; j < boxCol + 3; j++)
                {
                    if (board[i][j] != '.' && !box.Add(board[i][j])) return false;
                }
            }
        }

        return true;
    }
}