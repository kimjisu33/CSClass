using System;

namespace CSClass
{
    /// <summary>
    /// 자동차 주차장 입차, 출차 시간 등을 저장하는 클래스 입니다.
    /// </summary>
    internal class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public Car()
        {
        }

        /// <summary>
        /// 자동차 입차시간 지정합니다.
        /// </summary>
        internal void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차 출차 시간을 지정합니다.
        /// </summary>
        internal void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    
        /// <summary>
        /// 뭔가 입력받고 출력합니다.
        /// </summary>
        /// <param name="foo">뭔가 변수</param>
        /// <returns>뭔가 리턴값</returns>
        public int some(int foo)
        {
            return foo*10;
        }
        
        
    }
}