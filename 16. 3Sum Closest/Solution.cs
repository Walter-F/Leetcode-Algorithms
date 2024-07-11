public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
       int n=nums.Length;
       int minAns=int.MaxValue;
       int result=0;
       Array.Sort(nums);
       for(int i=0;i<n-2;i++)
       {
           int left=i+1;
           int right=n-1;
           while(left<right)
           {
               int values=nums[i]+nums[left]+nums[right];
               int diffOfValAndTarget=Math.Abs(values-target);
               if(minAns>diffOfValAndTarget)
                  {
                      result=values;
                      minAns=diffOfValAndTarget;
                  }
              if(values>target)
               right--;
               else
               left++;
            }
       }
       return result;
    }
}