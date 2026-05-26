public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left=0;
        var right=numbers.Length-1;
        int[] result = new int[2];
        while(left<right)
        {
            var curSum=numbers[left]+numbers[right];
            if(target<curSum)
                right--;
            else if(target>curSum)
                left++;
            else
                return new int[]{left+1, right+1}  ;     
        }
        return new int[0];
    }
}