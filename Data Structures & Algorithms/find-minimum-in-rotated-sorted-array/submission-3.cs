public class Solution {
    public int FindMin(int[] nums) {
        int r=nums.Length-1;
        int l= 0;
        int min=1001;
        if(r==l)
            return nums[0];
        while(l<r)
        {
            int mid=l +(r-l)/2;
            if(nums[mid]>nums[r] && nums[r]<nums[l])
            {
                if(nums[r]<min)
                    min=nums[r];
                l=mid+1;
            }
            else if(nums[mid]>nums[l]&& nums[l]<nums[r])
            {
                if(nums[l]<min)
                    min=nums[l];
                r=mid-1;
            }
            else
            {
                if(nums[mid]<min)
                    min=nums[mid];
                if(mid!= nums.Length && nums[mid]>nums[mid+1])
                    l=mid+1;
                else if(mid!= 0 && nums[mid]>nums[mid-1])
                    r=mid-1;
                else
                    break;
            }
        }
        return min;
    }
}
