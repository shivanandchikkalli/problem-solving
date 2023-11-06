public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        var storage = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!storage.ContainsKey(nums[i]))
                storage.Add(nums[i], i);
        }

        int j = 0;
        foreach (int i in storage.Keys)
            nums[j++] = i;

        return j;
    }
}