public class Solution {
    public bool hasDuplicate(int[] nums) {
        var ns = new HashSet<int>(nums);
        foreach (var n in nums)
        {
            ns.Add(n);
        }
        return ns.Count != nums.Length;
    }
}
