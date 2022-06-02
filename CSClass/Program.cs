﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        private static string name;
        private static int grade;

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


            Hamburger nyam = new Hamburger();

            //Product productA = new Product();
            //productA.name = "포켓몬빵";
            //productA.price = 1500;
            //Product productB = new Product(){ name="소금빵",price=2000};
            //Product productC = new Product(){ price=5500, name="당근케이크"};
            //Product productD = new Product(){ name="보름달"};


            List<Student> students = new List<Student>()
            {
                new Student() { name = "김지수", grade = 1 },
                new Student() { name = "김지가", grade = 1 },
                new Student() { name = "김지나", grade = 2 },
                new Student() { name = "김지다", grade = 3 },
                new Student() { name = "김지라", grade = 2 },
                new Student() { name = "김지마", grade = 1 },
                new Student() { name = "김지바", grade = 3 },
                new Student() { name = "김지사", grade = 3 },
                new Student() { name = "김지아", grade = 2 },
                new Student() { name = "김지자", grade = 1 }
            };

            /* foreach는 확인 수정 용
            foreach (var item in students)
            {
                if (item.grade > 2)
                {
                    students.Remove(item);
                }
            }    
            */

            /*
            for (int i=0; i<students.Count ; i++)
            {
                if(students[i].grade >2)
                {
                    //students.RemoveAt(i);
                    students.Remove(students[i]);
                    i--;
                }
            }*/

            for (int i = students.Count-1; i >= 0 ; i--)
            {
                if (students[i].grade > 2)
                {
                    //students.RemoveAt(i);
                    students.Remove(students[i]);
                }
            }

            foreach (var item in students)
            {
               Console.WriteLine(item);
            }


            Method method = new Method();
            Console.WriteLine(method.Multi(51.1,276));
            Console.WriteLine(method.Sum(1,100));
            Console.WriteLine(method.Multiply(1,10));

            Console.WriteLine(Method.Abs(-100));
            Console.WriteLine(Method.Abs(100));
            //Console.WriteLine(method.Abs(100)); c#은 객체로 클래스 메서드 호출 불가능


            //int
            Console.WriteLine(MyMath.Abs(-10));
            Console.WriteLine(MyMath.Abs(10));
            //double
            Console.WriteLine(MyMath.Abs(-10.1));
            Console.WriteLine(MyMath.Abs(10.1));
            //long
            Console.WriteLine(MyMath.Abs(-65464971164));
            Console.WriteLine(MyMath.Abs(65464971164));

            Product product = new Product();
            Console.WriteLine(Product.counter);
            Product product1 = new Product();
            Console.WriteLine(Product.counter);
            Product product2 = new Product();
            Console.WriteLine(Product.counter);

            //Console.WriteLine("첫번째위치");
            //Console.WriteLine(Sample.value);
            //Console.WriteLine("두번째위치");
            //Sample sample = new Sample();
            //Console.WriteLine("세번째위치");

            Console.WriteLine("첫번째위치");
            Sample sample = new Sample();
            Console.WriteLine("두번째위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세번째위치");
        }
    }

    
}
