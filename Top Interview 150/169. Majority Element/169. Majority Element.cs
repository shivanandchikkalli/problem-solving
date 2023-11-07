public class Solution {
    public int MajorityElement(int[] nums) {
        int majority = 0;
        int count = 0;

        foreach(int i in nums)
        {
            if(count == 0){
                majority = i;
                count = 1;
            }
            else if(i == majority)
                count++;
            else
                count--;
        }

        return majority;
    }
}

// You can solve this problem using a variety of algorithms, but one of the most efficient and commonly used approaches is the 
// "Boyer-Moore Voting Algorithm." This algorithm allows you to find the majority element in a given array in O(n) time complexity and O(1) space complexity.

// The idea behind this algorithm is to maintain a "candidate" element and a "count" of how many times it appears in the array. 
// We iterate through the array, and if the count reaches zero, we update the candidate to the current element. 
// If the current element is the same as the candidate, we increment the count; otherwise, we decrement it. 
// Since the majority element appears more than n/2 times, it will survive this process, and the candidate will be the majority element.