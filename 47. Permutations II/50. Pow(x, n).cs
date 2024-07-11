public class Solution
{
    private List<IList<int>> _result;

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        _result = new List<IList<int>>();
        Backtrack(nums, 0);
        return _result;
    }

    private void Backtrack(IList<int> nums, int begin)
    {
        //stop case
        if (begin == nums.Count - 1)
        {
            _result.Add(nums.ToArray());
        }

        var set = new HashSet<int>();

        for (int i = begin; i < nums.Count(); i++)
        {
            //skip duplicates
            if (!set.Add(nums[i])) continue;

            (nums[i], nums[begin]) = (nums[begin], nums[i]);

            Backtrack(nums, begin + 1);

            (nums[i], nums[begin]) = (nums[begin], nums[i]);
        }
    }
}