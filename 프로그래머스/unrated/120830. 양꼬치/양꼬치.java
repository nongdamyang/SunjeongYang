class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        int temp = 0;
        
        temp = (n / 10) * 2000;
        answer = (n * 12000 + k * 2000) - temp;
        
        return answer;
    }
}