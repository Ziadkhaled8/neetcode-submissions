public class Solution {
    public int MaxArea(int[] heights) {
        var max=0;
        var left=0;
        var right=heights.Length-1;
        var curHeight=0;
        while(left<right)
        { 
            var rHeight=heights[right];
            if(rHeight<=curHeight)
            {
                right--;
                continue;
            }
            var lHeight=heights[left];
            if(lHeight<=curHeight)
            {
                left++;
                continue;
            }
            curHeight=Math.Min(heights[left],heights[right]);
            var curMax=(curHeight*(right-left));
                if(curMax>max)
                    max=curMax;
        }
        return max;
    }
}
