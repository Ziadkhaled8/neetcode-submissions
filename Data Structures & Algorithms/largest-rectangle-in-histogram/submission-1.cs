public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var max=0;
        var stack=new Stack<int[]>();
        stack.Push(new int[]{0, heights[0]});
        for(int i =1;i<heights.Length;i++)
        {
            var index=i;
            if(stack.Count>0 && heights[i]<stack.Peek()[1])
            {
                while(stack.Count>0 && heights[i]<stack.Peek()[1])
                {
                    var cur=stack.Peek()[1] * (i-stack.Peek()[0]);
                    max=max<cur? cur : max;
                    index=stack.Peek()[0];
                    stack.Pop();
                }
            }
            stack.Push(new int[]{index, heights[i]});    
        }
        while(stack.Count>0)
        {
            var popped=stack.Pop();
            var cur=popped[1] * (heights.Length-popped[0]);
            max=max<cur? cur : max;
        } 
        return max;
    }
}
