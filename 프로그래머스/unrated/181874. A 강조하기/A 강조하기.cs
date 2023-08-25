using System;

public class Solution {
    public string solution(string myString) {
        
        myString = myString.ToLower();
        myString = myString.Replace("a", "A");
        
        return myString;
    }
}