using System;

public class Solution
{
    public int solution(int n, string control)
    {
        int answer = n;
        
        char[] arr = control.ToCharArray();
        
        for (int i = 0; i < arr.Length; i++)
        {
            switch (arr[i])
            {
                case 'w':
                    answer += 1;
                    break;
                case 's':
                    answer -= 1;
                    break;
                case 'd':
                    answer += 10;
                    break;
                case 'a':
                    answer -= 10;
                    break;
            }
        }
        return answer;
    }
}