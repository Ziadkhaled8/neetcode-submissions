public class Solution {
    public int EvalRPN(string[] tokens) {
        var operands=new Stack<int>();
        foreach(string c in tokens)
        {
            if(int.TryParse(c,out var num))
            {
                operands.Push(num);
            }
            else
            {
                var right=operands.Pop();
                var left=operands.Pop();
                switch(c)
                {
                    case "+":operands.Push(left+right);
                        break;
                    case "-":operands.Push(left-right);
                        break;
                    case "*":operands.Push(left*right);
                        break;
                    case "/":operands.Push(left/right);
                        break;
                }
            }
        }
            return operands.Pop();
    }
}
