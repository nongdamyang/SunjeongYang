using System;

public class Solution {
    public int solution(string message) {
        int answer = 0;
        
        char[] arr = message.ToCharArray();
        answer = arr.Length * 2;
        
        return answer;
    }
}