public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char num = board[i][j];
                if (num == '.') continue;

                if (!seen.Add($"{num} in row {i}") ||
                    !seen.Add($"{num} in col {j}") ||
                    !seen.Add($"{num} in box {i/3}-{j/3}"))
                    return false;
            }
        }

        return true;
    }
}
