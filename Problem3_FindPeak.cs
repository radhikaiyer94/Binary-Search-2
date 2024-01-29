// Time Complexity : O(logn)
// Space Complexity : O(1)
// Did this code successfully run on Leetcode : Yes
// Any problem you faced while coding this :
public class Solution {
    public int FindPeakElement(int[] nums) {
        int low = 0;
        int high = nums.Length - 1;
        while(low <= high) {
            int mid = low + (high - low)/2;
            if ((mid == 0 || nums[mid] > nums[mid - 1]) && 
            (mid == nums.Length - 1 || nums[mid] > nums[mid + 1])) {
                return mid;
            }
            else if (nums[mid] < nums[mid + 1]) {
                low = mid + 1;
            }
            else {
                high = mid - 1;
            }
        }
        return -1;
    }
}