public class Solution {
    public bool IsSubsequence(string s, string t) {
        int one = 0;
        int two = 0;

        int i = 0 ; 
        while(i < t.Length && one < s.Length)
        {
            if(s[one] == t[i]) {
                one++;
                i++;
            }
            else
                i++;
        }

        if(one == s.Length)
            return true;
        else
            return false;
    }
}