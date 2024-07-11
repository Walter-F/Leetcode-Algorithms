public class Solution {
    public void NextPermutation(int[] nums) {
        if(nums.Length <= 1) return;

        int right = nums.Length - 2;

        while(right >= 0 && nums[right] >= nums[right+1])
            right--;
        
        int pivotIndex = right; 

        if(pivotIndex >= 0) {
            right = nums.Length - 1;
            while(right >= 0 && nums[pivotIndex] >= nums[right]) right--;
            swap(nums, pivotIndex, right);
        }
        
        int L = pivotIndex+1;
        int R = nums.Length - 1;
        while(L < R)
        {
            swap(nums, L++, R--); 
        }
    }

    private void swap(int [] nums, int L, int R)
    {
        int temp = nums[L];
        nums[L] = nums[R];
        nums[R] = temp;
    }
}
