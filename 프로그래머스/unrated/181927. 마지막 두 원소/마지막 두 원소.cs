using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length + 1];
        
        int last = 0; 
        
        int a = num_list[num_list.Length - 1];
        int b = num_list[num_list.Length - 2];
        
        if(a > b)
            last = a - b;
        else
            last = a * 2;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            answer[i] = num_list[i];
        }
        
        answer[answer.Length - 1] = last;
        
        return answer;
    }
}