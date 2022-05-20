using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);

            /*
            List<int> list =new List<int>();
            list.Add(1);
            list.Add(222);
            list.Add(4545);
            */

            List<int> list = new List<int>() { 51, 273, 62, 24 };
            list.Remove(51); //51을 지움
            foreach(var item in list)
            {
                Console.WriteLine("Count : "+list.Count+"\titem : "+item);
            }
            


            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52,273));
            Console.WriteLine(Math.Min(52,273));
            Console.WriteLine(Math.Round(52.273));
        }
    }
}
