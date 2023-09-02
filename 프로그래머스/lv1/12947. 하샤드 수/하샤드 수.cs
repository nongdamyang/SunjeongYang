using System;

public class Solution {
    public bool solution(int x) {
        bool answer = true;
        
        string result = x.ToString();
        
        int sum = 0; 
        
        for (int i = 0; i < result.Length; i++)
        {
            sum += (int)Char.GetNumericValue(result[i]);
        }
        
        answer = x % sum == 0 ? true : false;
        
        return answer;
    }
}