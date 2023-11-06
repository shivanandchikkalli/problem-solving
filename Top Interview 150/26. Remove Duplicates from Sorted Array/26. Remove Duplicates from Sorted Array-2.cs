public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        int i = 0;
        int j = 1;

        while (j < nums.Length)
        {
            if (nums[i] == nums[j])
                j++;
            else if (nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j++];
            }
        }

        return i + 1;
    }
}