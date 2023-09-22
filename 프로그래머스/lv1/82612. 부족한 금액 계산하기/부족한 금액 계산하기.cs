using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long sum = price * ((long)count*(count+1)/2);
        
        return ((long)money-sum) < 0 ? sum-money : 0;
    }
}