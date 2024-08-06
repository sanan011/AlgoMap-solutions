public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int word1Length = word1.Length;
        int word2Length = word2.Length;
        int longestWord = Math.Max(word1Length, word2Length);
        
        string output = "";
        for(int i = 0; i < longestWord; i++) {
            if (i < word1Length) {
                output += word1[i];
            }
            if (i < word2Length) {
                output += word2[i];
            }
        }
        return output;
    }
}
