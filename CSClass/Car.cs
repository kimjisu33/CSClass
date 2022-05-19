using System;

namespace CSClass
{
    internal class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public Car()
        {
        }

        internal void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        internal void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}