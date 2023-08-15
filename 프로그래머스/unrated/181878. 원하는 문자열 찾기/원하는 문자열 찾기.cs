using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        
        if(myString.ToLower().Contains(pat.ToLower()))
        {
            answer = 1;
        }
        
        return answer;
    }
}