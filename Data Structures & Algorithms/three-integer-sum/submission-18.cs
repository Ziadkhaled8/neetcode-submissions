public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!frequencyMap.ContainsKey(nums[i]))
                frequencyMap[nums[i]] = 0;
            else
                frequencyMap[nums[i]]++;
        }
        var result= new List<List<int>>();
        var left=0;
        var right=nums.Length-1;
        while(left<right)
        {
            while(left<right) 
            {
                var abs=0-(nums[left]+nums[right]); 
                if(abs<=nums[right])
                {
                    if(frequencyMap.ContainsKey(abs) && nums[left]<=abs) 
                    {
                        if(!((nums[left]== abs || nums[right]==abs) && frequencyMap[abs] <= 0))
                        {
                            if(nums[left]==abs && nums[right]==abs)
                            {
                                if(frequencyMap[abs]<2)
                                {
                                }
                                else
                                {
                                    var triple=new List<int> {nums[left],abs,nums[right]};
                                    if (!result.Any(l => l.SequenceEqual(triple)))
                                    {
                                        result.Add(triple);
                                    }
                                }
                            }
                            else
                            {
                                var triple=new List<int> {nums[left],abs,nums[right]};
                                if (!result.Any(l => l.SequenceEqual(triple)))
                                {
                                    result.Add(triple);
                                }
                            }
                        }
                    }
                }
                right--;
            }
            right=nums.Length-1;
            left++;
            
        }
        return result;
    }
}
