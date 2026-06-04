public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] counts = new int[26];
        foreach (var s1 in s)
        {
            counts[s1 - 'a']++;
        }

        foreach (var t1 in t)
        {
            counts[t1 - 'a']--;
        }
        foreach (int count in counts) {
            if (count != 0) return false;
        }
        return true;
    }
}
