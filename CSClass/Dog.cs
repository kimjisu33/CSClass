using System;

namespace CSClass
{
    internal class Dog
    {
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog()
        {
            this.Age = 0;
        }
        public void Eat()
        {
            Console.WriteLine("개가 먹는다");
        }

        public void Sleep()
        {
            Console.WriteLine("개가 잔다");
        }

        public void Bark()
        {
            Console.WriteLine("개가 짖는다");
        }
    }
}