using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        int result = 0;
        
        char[] arr = num_str.ToCharArray();
        
        for(int i = 0; i < arr.Length; i++)
        {
            result = arr[i] - '0';
            answer += result;
        }
        
        return answer;
    }
}