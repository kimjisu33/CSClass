using System;

namespace CSClass
{
    public class Parent
    {
        public static int counter = 0;
        public void CounteParent()
        {
            Parent.counter++;
        }
        public Parent()
        {
            Console.WriteLine("Parent(int param)");
        }
        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }
        public Parent(string param)
        {
            Console.WriteLine("Parent(string param)");
        }

    }
}