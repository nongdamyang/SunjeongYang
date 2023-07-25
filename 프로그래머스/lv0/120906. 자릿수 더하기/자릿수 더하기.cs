using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        string result = n.ToString();
        
        char[] arr = result.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            answer += Int32.Parse(arr[i].ToString());
        }
        
        return answer;
    }
}