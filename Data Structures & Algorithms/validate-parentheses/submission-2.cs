public class Solution {
    public bool IsValid(string s) {
        var bracketPairs = new Dictionary<char, char>
        {
            { ')', '(' }, { '}', '{' }, { ']', '[' }
        };
        var stack=new Stack<char>();
        foreach(char c in s)
        {
            if(bracketPairs.ContainsKey(c))
                {
                    if(stack.Count>0 && stack.Peek()==bracketPairs[c])
                    {
                        stack.Pop();
                    }
                    else 
                        return false;
                }
            else
                stack.Push(c);



        }
        
        return stack.Count==0;
    }
}
