using System;

namespace CSClass
{
    internal class Cat : Animal
    {
        public Cat()
        {
            this.Age = 0;
        }

        public void Meow()
        {
            Console.WriteLine("고양이가 짖는다");
        }

        public override void Eat()
        {
            Console.WriteLine("고양이 사료를 먹습니다");
        }
    }
}