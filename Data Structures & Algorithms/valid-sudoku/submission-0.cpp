class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board) {
        unordered_map<char,int> checkMap;
         for (char ch = '1'; ch <= '9'; ++ch) {
            checkMap[ch] = 0;
        }
        checkMap['.']=0;
        for(int i=0; i<board.size();i++)
        {
            for(auto x : board[i])
            {
                checkMap[x]++;
            }
            for(auto& pair : checkMap) {
                if (pair.second > 1 && pair.first!='.') {
                    return false;
                }
                pair.second=0;
            }
        }
        for(int y=0; y<9;y++)
        {
            for(int i=0; i<9;i++)
            {
                checkMap[board[i][y]]++;
            }
            for(auto& pair : checkMap) {
                if (pair.second > 1 && pair.first!='.') {
                    return false;
                }
                pair.second=0;
            }
        }
        for (int boxRow = 0; boxRow < 3; ++boxRow) {
        for (int boxCol = 0; boxCol < 3; ++boxCol) {
            for (int i = 0; i < 3; ++i) {
                for (int j = 0; j < 3; ++j) {
                    checkMap[board[boxRow * 3 + i][boxCol * 3 + j]]++;
                }
            }
            for(auto& pair : checkMap) {
                if (pair.second > 1 && pair.first!='.') {
                    return false;
                }
                pair.second=0;
            }
        }
    }
    }
};
