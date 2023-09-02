using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        for (int i = 1; i <= 9; i++)
        {
            answer += i;
        }
        
        for (int i = 0; i < numbers.Length; i++)
        {
            answer -= numbers[i];
        }
        
        return answer;
    }
}