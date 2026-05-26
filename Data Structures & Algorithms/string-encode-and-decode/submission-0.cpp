class Solution {
public:

    string encode(vector<string>& strs) {
        string encoded;
        for(auto str: strs)
            encoded+=str+"/";
        return encoded;
    }

    vector<string> decode(string s) {
        vector<string> result;
        stringstream ss(s);
        string str;
        while(getline(ss, str, '/'))
            result.push_back(str);
        return result;
    }
};
