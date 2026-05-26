public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var left=0;
        var right= matrix.GetLength(0)-1;
        int mid=0;
        while(left<=right)
        {
            mid=left + (right - left) / 2;
            if(target>=matrix[mid][0] && target<=matrix[mid][matrix[mid].Length-1])
                break;
            if(target>matrix[mid][0])
                left=mid+1;
            else
                right=mid-1;
        }
        Console.WriteLine(mid);
        right=matrix[mid].Length-1;
        left=0;
        int xMid=mid;
        while(left<=right)
        {
            mid=left + (right - left) / 2;
            if(target==matrix[xMid][mid])
                return true;
            if(target>matrix[xMid][mid])
                left=mid+1;
            else
                right=mid-1;
        }
        return false;
        
    }
}
