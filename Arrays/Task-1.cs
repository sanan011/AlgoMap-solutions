public class Solution {
    public int FindClosestNumber(int[] nums) {
        int closestNumber = nums[0];
        
        for (int i = 1; i < nums.Length; i++) {
            int currentDistance = Math.Abs(nums[i]);
            int closestDistance = Math.Abs(closestNumber);
            
            if (currentDistance < closestDistance || 
                (currentDistance == closestDistance && nums[i] > closestNumber)) {
                closestNumber = nums[i];
            }
        }

        return closestNumber;
    }
}
