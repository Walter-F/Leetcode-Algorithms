public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        // Create a list to store the combinations
        IList<IList<int>> combinations = new List<IList<int>>();

        // Create a list to store the current combination
        List<int> current = new List<int>();

        // Recursively find the combinations
        findCombinationsRecursive(candidates, target, 0, current, combinations);

        return combinations;
    }

    void findCombinationsRecursive(int[] candidates, int target, int index, IList<int> current, IList<IList<int>> combinations)
    {
        // If the target is 0, we have found a combination
        if (target == 0)
        {
            combinations.Add(current);
            return;
        }

        // If the target is negative or we have reached the end of the array, return
        if (target < 0 || index == candidates.Length)
        {
            return;
        }

        // Recursively find combinations with and without the current element
        List<int> withCurrent = new List<int>(current);
        withCurrent.Add(candidates[index]);
        findCombinationsRecursive(candidates, target - candidates[index], index, withCurrent, combinations);
        findCombinationsRecursive(candidates, target, index + 1, current, combinations);
    }
}