public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        int j = nums.Length - 1;
        int i = 0;
        while (i < nums.Length && j >= 0)
        {
            if (i == j)
            {
                i++;
                j = nums.Length - 1;
                continue;
            }
            if (nums[i] + nums[j] == target)
            {
                return [i, j];
            }
            
           

            j--;
        }
        return [-1,-1];
    }
}