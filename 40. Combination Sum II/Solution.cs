public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        IList<IList<int>> answer = new List<IList<int>>();
        int total = 0; 
        int i = 0;
        List<int> current = new List<int>();
        Array.Sort(candidates);
        backtracking(answer, current, i, total, target, candidates);
        return answer;
    }

    public void backtracking(IList<IList<int>> answer, List<int> current, int i, int total, int target, int[] candidates)
    {
        if (total == target)
        {
            answer.Add(new List<int>(current));
            return;
        }
        if (total > target)
        {
            return;
        }
        if (i == candidates.Length)
        {
            return;
        }
        current.Add(candidates[i]);
        total = total + candidates[i];
        backtracking(answer, current, i+1, total, target,candidates);
        current.RemoveAt(current.Count-1);
        total = total - candidates[i];
        while((i+1) < candidates.Length && candidates[i] == candidates[i+1])
        {
            i = i + 1; 
        }
        backtracking(answer, current, i+1, total, target, candidates);
    }
}