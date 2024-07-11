public class Solution {
    public int FirstMissingPositive(int[] nums) {
        HashSet<int> set = new ();
        int startValue = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            set.Add(nums[i]);
            if(startValue == nums[i])
            {
                while(set.Contains(startValue))
                {
                    startValue++;
                }
            }
        }
        return startValue;
    }
}