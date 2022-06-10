using System;

namespace CSClass
{
    internal class Cat
    {

        public int Age { get; set; }
        public Cat()
        {
            this.Age = 0;
        }
        public void Eat()
        {
            Console.WriteLine("고양이가 먹는다");
        }

        public void Sleep()
        {
            Console.WriteLine("고양이가 잔다");
        }

        public void Meow()
        {
            Console.WriteLine("고양이가 짖는다");
        }
    }
}