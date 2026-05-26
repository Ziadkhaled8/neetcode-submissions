public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left=1;
        int right=piles.Max();
        int min=right;
        while(left<=right)
        {
            int mid=(left +right)/2;
            long curHours=0;
            foreach(var x in piles)
            {
                curHours+= (int)Math.Ceiling((double)x/mid);
            }

            if(curHours<=h)
            {
                min=mid;
                right=mid-1;
            }

            else
            {
                left=mid+1;
            }
        }
        return min;
        
        
    } 
}
