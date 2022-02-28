using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Solution {
    public int[] twoSum(int[] nums, int target) {
        int length = nums.length;
        Map<Integer, Integer> map = new HashMap<Integer, Integer>(length);
        for (int i=0; i<length; i++) {
            map.put(nums[i], i);
        }
 
        for (int i=0; i<length; i++) {
            int s = target - nums[i];
            if (map.containsKey(s) && i != map.get(s)) {
                return new int[]{i, map.get(s)};
            }
        }
 
        return new int[0];
    }
}