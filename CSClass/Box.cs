namespace CSClass
{
    class Box
    {
        public int width;
        public int height;

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}