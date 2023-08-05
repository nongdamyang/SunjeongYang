using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        int mul = 1;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            if(num_list.Length >= 11)
            {
                answer += num_list[i];
            }
            else if(num_list.Length <= 10)
            {
                mul *= num_list[i];
                answer = mul;
            }
        }
        
        return answer;
    }
}