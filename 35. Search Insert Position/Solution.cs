public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            if(target > nums[i])
            {
                continue;
            }
            else if(target <= nums[i])
            {
                return i;
            }
        }

        if(nums[nums.Length-1] < target)
            return nums.Length;
        else
            return 0;
        
    }
}