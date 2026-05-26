public class Solution {
    public int LongestConsecutive(int[] nums) {
        int res = 0;
        HashSet<int> store = new HashSet<int>(nums);

        foreach (int num in nums) {
            int streak = 0, curr = num;
            while (store.Contains(curr)) {
                streak++;
                curr++;
            }
            res = Math.Max(res, streak);
        }
        return res;
    }
}
//2,20,10,1,2,3,2,5,0,1,2,3