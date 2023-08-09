using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        int result1 = 1;
        int result2 = 0;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            result1 *= num_list[i];
            result2 += num_list[i];
        }
        
        if(result1 > Math.Pow(result2, 2))
        {
            answer = 0;
        }
        else
        {
            answer = 1;
        }
        
        return answer;
    }
}