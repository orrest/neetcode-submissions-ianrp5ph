public class Solution {
    public bool Exist(char[][] board, string word) {
        bool[][] visited = new bool[board.Length][];
        for (int i = 0; i < visited.Length; i++) {
            visited[i] = new bool[board[0].Length];
        }

        for (int r = 0; r < board.Length; r ++) {
            for (int c = 0; c < board[0].Length; c ++) {
                bool res = dfs(board, word, r, c, 0, visited);
                if (res) {
                    return true;
                }
            }
        }

        return false;
    }

    private bool dfs(
        char[][] board, 
        string word, 
        int r, 
        int c,
        int i, 
        bool[][] visited) 
    {
        if (i == word.Length) {
            return true;
        }

        if (r < 0 || r >= board.Length 
            || c < 0 || c >= board[0].Length
            || word[i] != board[r][c]
            || visited[r][c]) {
                return false;
        }

        visited[r][c] = true;
        bool res = dfs(board, word, r + 1, c, i + 1, visited) ||
                   dfs(board, word, r - 1, c, i + 1, visited) ||
                   dfs(board, word, r, c + 1, i + 1, visited) ||
                   dfs(board, word, r, c - 1, i + 1, visited);
        visited[r][c] = false;

        return res;
    }
}
