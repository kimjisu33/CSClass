using System;

namespace CSClass
{
    internal class Box3
    {
        private int width;
        private int height;

       

        public int Width 
        {
            get { return width; }
            set
            {
                if (value > 0) width = value;
                else Console.WriteLine("양수를 입력해주세요!!!");
            } 
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
                else Console.WriteLine("양수를 입력해주세요!!!");
            }
        }

        public int Area
        { get { return width * height; } }

        public Box3(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}