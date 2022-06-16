using System;

namespace CSClass
{
    internal class Dog : Animal
    {
        
        public Dog()
        {
            this.Age = 0;
        }

        public void Bark()
        {
            Console.WriteLine("개가 짖는다");
        }

        public override void Eat()
        {
            Console.WriteLine("강아지 사료를 먹습니다");
        }
    }
}