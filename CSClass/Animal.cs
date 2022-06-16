using System;

namespace CSClass
{
    internal class Animal
    {

        public int Age { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine("고양이가 먹는다");
        }

        public void Sleep()
        {
            Console.WriteLine("고양이가 잔다");
        }
        


    }
}