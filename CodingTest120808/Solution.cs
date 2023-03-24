public class Solution
{
    //분자 : numer
    //분모 : denom
    //두 분수의 합을 기약분수로 표현하기

    //1. 서로의 분자 분모를 곱함
    //2. 그 후 더한후 약분을 함
    //3. 출력

    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int[] answer = new int[2];

        int resultNumer = numer1 * denom2 + numer2 * denom1;
        int resultDenom = denom1 * denom2;

        //최대 공약수는 어떻게 구할 수 있나요?
        // X - nY 에서 0을 결과값으로 만들 수 있는 수가 최대공약수

        int x = resultNumer;
        int y = resultDenom;
        if (resultNumer < resultDenom)
        {
            x = resultDenom;
            y = resultNumer;
        }
        while (y > 0)
        {
            int temp = x % y;
            x = y;
            y = temp;
            //y가 0이되는순간 x는 최대공약수가 되고 루프문 탈출
        }

        answer[0] = resultNumer/ x;
        answer[1] = resultDenom/ x;
        return answer;
    }
}