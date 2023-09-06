using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[] {};
        
        List<int> array = new List<int>();
        
        int length = arr.Length;
        
        for(int i = 0; i < length; i++)
        {
            if(length % 2 == 1 && i % 2 == 0)
            {
                array.Add(arr[i] + n);
            }
            else if(length % 2 == 0 && i % 2 == 1)
            {
                array.Add(arr[i] + n);
            }
            else
            {
                array.Add(arr[i]);
            }
        }
        
        answer = array.ToArray();
        
        return answer;
    }
}