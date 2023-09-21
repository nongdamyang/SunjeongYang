using System;

public class Solution {
    public int solution(int[] a, int[] b) {
        int answer = 0;
        //반복문을 통해 해당 배열순서의 정수를 곱해 answer에 더함.
        for(int i=0; i<a.Length; i++)
        {
            answer += a[i] * b[i];
        }
        return answer;
    }
}