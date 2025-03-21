namespace _00.LevelTest_NextLevel
{
    internal class Program
    {
        public static int SumOfDigits(int number)
        {
            // 각 자리 수의 합을 담기 위한 정수형 변수
            int result = 0;

            // while 반복문이 number보다 클 때 동작하도록 설정
            while (number > 0)
            {
                // 
                result += number / 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            // 주어진 숫자의 각 자리수의 합을 구하는 함수를 작성하시오.
           
            
        }
    }
}
