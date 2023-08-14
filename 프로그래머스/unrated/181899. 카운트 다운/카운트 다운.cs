using System;

public class Solution {
    public int[] solution(int start, int end) {
        int[] answer = new int[start - end + 1];
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = start;
            start--;
        }
        
        return answer;
    }
}