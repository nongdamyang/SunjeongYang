using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        
        Array.Sort(sides);
        
        int result = sides[0] + sides[1];
        
        if(sides[2] < result)
        {
            answer = 1;
        }
        else {
            answer = 2;
        }
        
        return answer;
    }
}