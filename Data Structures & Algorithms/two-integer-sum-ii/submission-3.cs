public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left=0;
        var right=numbers.Length-1;
        int[] result = new int[2];
        while(right!=left && left<right)
        {
            
            while(right!=left && left<right)
            {
                if(numbers[left]+numbers[right]==target)
                {
                    result[0]=left+1;
                    result[1]=right+1;
                    return result;
                }
                right--;
            }
            right=numbers.Length-1;
            left++;
        }
        return result;
    }
}