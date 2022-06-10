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
    }
}