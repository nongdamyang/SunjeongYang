using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 0;
        
        answer = my_string.EndsWith(is_suffix) ? 1 : 0;
        
        return answer;
    }
}