public class Solution {
    public bool IsPalindrome(string s) {
        s = System.Text.RegularExpressions.Regex.Replace(s, "[^a-zA-Z0-9]", "");
        if(string.IsNullOrWhiteSpace(s))
            return true;
        s=s.ToLower();
        var right=s.Length-1;
        var left=0;
        while(right!=left && left<right)
        {
            if(s[left]==s[right])
            {
                right--;
                left++;
                continue;
            }
            return false;
        }
        return true;
    }
}
