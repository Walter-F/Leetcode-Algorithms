//Greedy Approach
public class Solution {
    public int Jump(int[] nums) {
        int length=nums.Length;

        int highJump=0;
        int jump=0;
        int currPos=0;
        // corner case :only one positio don't need jump
        if(length==1){
            return 0;
        }
        // base case : If start position given range,you won't jump more So,return -1;
        if(nums[0]==0){
            return -1;
        }
        //Loop through steps 
        for(int i=0;i<length;i++){
            highJump=Math.Max(highJump, i+nums[i]);
            // When the jump reaches the end return the total jumps
            if(highJump>=length-1){
                return jump+1;
            }
            if(i==currPos){
                currPos=highJump;
                jump++;
            }
        }
        return -1;
    }
}