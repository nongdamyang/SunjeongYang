using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        string result1 = a.ToString() + b.ToString();
        string result2 = b.ToString() + a.ToString(); 
        
        if(Int32.Parse(result1) > Int32.Parse(result2))
            answer = Int32.Parse(result1);
        else if(Int32.Parse(result1) < Int32.Parse(result2))
            answer = Int32.Parse(result2);
        else if (Int32.Parse(result1) == Int32.Parse(result2)) 
            answer = Int32.Parse(result1);
        
        return answer;
    }
}