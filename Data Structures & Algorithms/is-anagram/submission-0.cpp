class Solution {
public:
    bool isAnagram(string s, string t) {
        vector<int> alph(26,0);
        for(char i : s)
            alph[i-'a']++;
        for(char i : t)
            alph[i-'a']--;
        for(int i : alph)
        {
            if(i!=0)
                return false;
        }
        return true;
    }
};
