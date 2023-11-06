public class Solution {
    public bool IsPalindrome(string s) {
        int start = 0;
        int end = s.Length - 1;
        s = s.ToLower();

        while(start < end){
            if(!(((48 <= (int)s[start] && (int)s[start] <= 57) || (97 <= (int)s[start] && (int)s[start] <= 122)) && (int)s[start] != 32)){
                start++;
                continue;
            }
            if(!(((48 <= (int)s[end] && (int)s[end] <= 57) || (97 <= (int)s[end] && (int)s[end] <= 122)) && (int)s[end] != 32)){
                end--;
                continue;
            }

            if(s[end--] != s[start++]){
                return false;
            }
        }

        return true;
    }
}