class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int,int> freq;
        vector<int>res;
        for(int num:nums)
        {
            freq[num]++;
        }
        vector<pair<int,int>> freqVec(freq.begin(),freq.end());
        sort(freqVec.begin(),freqVec.end(),
        [](pair<int,int>a, pair<int,int>b){
            return (a.second==b.second? (a.first<b.first): a.second>b.second);
        });
        for(int i=0;i<k;i++){
            res.push_back(freqVec[i].first);
        }
       
    
        return res;
    }
};
