public class Solution {
    public void NextPermutation(int[] nums) {
        if(nums.Length <= 1) return;

        int right = nums.Length - 2;
        /*finding the increasing suffix from right side*/
        while(right >= 0 && nums[right] >= nums[right+1])
            right--;
        
        int pivotIndex = right; /*pivot index, from the increasing suffix starts decreasing*/

        if(pivotIndex >= 0) {
            right = nums.Length - 1; //reset right counter to
            while(right >= 0 && nums[pivotIndex] >= nums[right]) right--; //finding the right most successor of pivot element.

            //swap
            swap(nums, pivotIndex, right);
        }
        
        
        //reverse the suffix
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