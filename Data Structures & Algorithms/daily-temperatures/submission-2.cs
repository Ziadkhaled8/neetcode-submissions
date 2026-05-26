public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result=new int[temperatures.Length];
        var stack=new Stack<int[]>();
        stack.Push(new int[]{temperatures[0],0});
        for(int i=1;i<temperatures.Length;i++)
        {
            while(stack.Count>0 && temperatures[i]>stack.Peek()[0])
            {
                var popped=stack.Pop();
                result[popped[1]]=i-popped[1];
            }
            stack.Push(new int[] {temperatures[i],i});
        }
        while(stack.Count>0)
        {
            var popped=stack.Pop();
                result[popped[1]]=0;
        }
        return result;
    }
}
