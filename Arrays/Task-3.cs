public class Solution {
    public int RomanToInt(string s){
    Dictionary<char, int> romanMap = new Dictionary<char, int>{
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
        
    int total = 0;
    int length = s.Length;

    for (int i = 0; i < length; i++){
        int value = romanMap[s[i]];
        if (i < length - 1 && romanMap[s[i]] < romanMap[s[i + 1]]) {
            total -= value;
        }
        else{
            total += value;
        }
    }
        
    return total;
        
}

}
