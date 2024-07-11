public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        for (var k = 0; k < nums.Length - 3; k++)
        {
            if (k > 0 && nums[k] == nums[k - 1]) continue;
            for (var i = k + 1; i < nums.Length - 2; i++)
            {
                if (i > k + 1 && nums[i] == nums[i - 1]) continue;
                long toFind = (long)target - (nums[i] + nums[k]);
                var l = i + 1;
                var r = nums.Length - 1;

                while (l < r)
                {
                    long sum = nums[l] + nums[r];
                    if (sum == toFind)
                    {
                        result.Add([nums[k], nums[i], nums[l], nums[r]]);
                        while (l < r && nums[l] == nums[l - 1]) l++;
                        while (l < r && nums[r] == nums[r - 1]) r--;
                    }

                    if (sum < toFind)
                        l++;
                    else
                        r--;
                }
            }
        }
        
        return result;
    }
}