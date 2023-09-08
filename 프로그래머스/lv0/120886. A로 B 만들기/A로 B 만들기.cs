using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        
        char[] b = before.ToCharArray();
        char[] a = after.ToCharArray();
        
        Array.Sort(b);
        Array.Sort(a);

        string bbb = new string(b);
        string aaa = new string(a);

        if(bbb.Equals(aaa))
            answer = 1;
        else
            answer = 0;

        return answer;
    }
}