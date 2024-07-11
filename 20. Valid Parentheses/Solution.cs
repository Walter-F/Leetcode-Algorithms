public class Solution {
    public bool IsValid(string parentheses) {
        Stack<char> stack = new();

        Dictionary<char, char> dict = new(){
            {'(', ')'}, 
            {'{', '}'}, 
            {'[', ']'}
        };

        for (int i = 0; i < parentheses.Length; i++)
        {
            if(dict.Keys.Contains(parentheses[i]))
                stack.Push(parentheses[i]); 
            else if(stack.Count > 0 && parentheses[i] == dict[stack.Peek()])
                stack.Pop();
            else
                return false;
        }

        return stack.Count == 0;
    }
}