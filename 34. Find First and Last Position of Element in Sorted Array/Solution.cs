public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = FindFirstOccurrence(nums, target);
        int right = FindLastOccurrence(nums, target);

        return new int[] { left, right };
    }

    private int FindFirstOccurrence(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int firstOccurrence = -1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (nums[mid] >= target) {
                if (nums[mid] == target)
                    firstOccurrence = mid;
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }

        return firstOccurrence;
    }

    private int FindLastOccurrence(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int lastOccurrence = -1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (nums[mid] <= target) {
                if (nums[mid] == target)
                    lastOccurrence = mid;
                left = mid + 1;
            }
            else {
                right = mid - 1;
            }
        }

        return lastOccurrence;
    }
}