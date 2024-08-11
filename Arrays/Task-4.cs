public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0, j = 0;
        s.ToLower();
        t.ToLower();

        while (i < s.Length && j < t.Length) {
            if (s[i] == t[j]) {
                i++;
            }
            j++;
        }

        return i == s.Length;
    }
}
