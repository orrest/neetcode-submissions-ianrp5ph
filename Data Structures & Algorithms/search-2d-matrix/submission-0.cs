public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // binary search between rows,
        // binary search in row

        int m = matrix.Length;
        int n = matrix[0].Length;

        int startRow = 0, endRow = m - 1;
        int midRow = startRow + (endRow - startRow) / 2;
        while (startRow <= endRow) {
            midRow = startRow + (endRow - startRow) / 2;
            int midRowStartVal = matrix[midRow][0];
            int midRowEndVal = matrix[midRow][n-1];
            if (midRowStartVal == target || midRowEndVal == target) {
                return true;
            } else if (midRowStartVal < target && midRowEndVal > target) {
                break;
            }

            if (target > midRowStartVal) {
                startRow = midRow + 1;
            } else {
                endRow = midRow - 1;
            }
        }

        // midRow
        int startCol = 0, endCol = n - 1;
        while (startCol <= endCol) {
            int midCol = startCol + (endCol - startCol) / 2;
            int midColVal = matrix[midRow][midCol];
            if (midColVal == target) {
                return true;
            }

            if (target > midColVal) {
                startCol = midCol + 1;
            } else {
                endCol = midCol - 1;
            }
        }

        return false;

    }
}
