class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
       unordered_set<int> num;

        for(int i = 0 ; i < nums.size() ; i++){
            num.insert(nums[i]);
        }

        return num.size() != nums.size();
    }
};
