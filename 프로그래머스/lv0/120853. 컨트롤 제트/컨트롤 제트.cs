using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        string[] arr = s.Split(" ");
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == "Z")
            {
                answer -= int.Parse(arr[i - 1]);
                continue;
            }
                
            answer += int.Parse(arr[i]);
        }
        
        return answer;
    }
}