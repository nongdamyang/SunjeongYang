using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[] {};
        
        List<int> array = new List<int>();
        for(int i = n - 1; i < num_list.Length; i++)
            array.Add(num_list[i]);
        
        answer = array.ToArray();
        
        return answer;
    }
}