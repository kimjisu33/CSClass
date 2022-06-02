using System;

namespace CSClass
{
    public class Sample
    {
        public static int value = 20;

        static Sample()
        {
            value = 90;
            Console.WriteLine("Sample() 정적 생성자 호출!!");
        }

        public Sample()
        {
            Console.WriteLine("일반생성자1!!!!!!");
        }
        ~Sample()
        {
            Console.WriteLine("Sample 객체가 소멸되었습니다!!!!!!!!!!!!!!!!!");
        }
    }
}