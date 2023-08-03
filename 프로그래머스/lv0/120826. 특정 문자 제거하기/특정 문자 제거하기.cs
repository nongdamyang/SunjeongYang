using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = "";
        
        string[] arr = my_string.Split(letter);
        
        for(int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }
        
        return answer;
    }
}