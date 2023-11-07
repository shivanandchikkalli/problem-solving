public class Solution {
    public int StrStr(string haystack, string needle) {
    
        return haystack.IndexOf(needle);
        
        // for(int i = 0 ; i < haystack.Length - needle.Length + 1; i ++)
        // {
        //     if(haystack.Substring(i, needle.Length) == needle){
        //         return i;
        //     }
        // }
        // return -1;

        // for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
        // {
        //     int counter = 0, k = 0;
        //     //int k = 0;
        //     for (int j = i; j < haystack.Length && k < needle.Length; j++)
        //     {
        //         if (needle[k++] != haystack[j])
        //             break;
        //         else
        //             counter++;
        //     }
        //     if (counter == needle.Length)
        //         return i;
        // }
        // return -1;       

    }
}