using System.Linq;
using System;

public class Solution {
    public int[] solution(long n) {
        
        
        string num = n.ToString();
        
        int[] answer = new int[num.Length];
        
        
        for(int i = 0; i < num.Length; i++)
        {
            answer[i] =  int.Parse(num[i].ToString());
        }
        
        Array.Reverse(answer);
        
        return answer;
    }
}