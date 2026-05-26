public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result=new int[temperatures.Length];
        for(int i=0;i<temperatures.Length-1;i++)
        {
            for(int j=i+1;j<temperatures.Length;j++) 
            {
                if(temperatures[i]<temperatures[j]) 
                {
                    result[i]=j-i;             
                    break;
                }
            }
        }
        result[temperatures.Length-1]=0;
        return result;
    }
}
