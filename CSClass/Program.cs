using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        public static int number = 0;

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

            Box box1 = new Box(10, 10);
            box1.width = -10;
            Console.WriteLine("box1의 면적은 "+box1.Area());

            Box2 box2 = new Box2(10, 10);
            box2.setWidth(-10);
            Console.WriteLine("box2의 면적은 " + box2.Area());

            Box3 box3 = new Box3(10, 10);
            box3.Width = -10;
            Console.WriteLine("box3의 면적은 " + box3.Area);

            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(10));
            Console.WriteLine(Fibonacci.Get(100));



            // List<Dog> Dogs = new List<Dog> { new Dog(), new Dog(), new Dog() };
            //List<Cat> Cats = new List<Cat> { new Cat(), new Cat(), new Cat() };
            List<Animal> animals = new List<Animal> { new Dog(), new Cat() };

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();
                //item.Meow();

                var dog = item as Dog;
                if (dog != null) dog.Bark();

                var cat = item as Cat;
                if (cat != null) cat.Meow();
                /*
                if (item is Dog)
                {
                    ((Dog)item).Bark();
                }else if(item is Cat)
                {
                    ((Cat)item).Meow();
                }
                */


                Child childA = new Child();
                Child childB = new Child("string");

                Parent parent = new Parent();
                Child child = new Child();
                Console.WriteLine(Parent.counter+" "+ Child.counter);
                parent.CounteParent();
                Console.WriteLine(Parent.counter + " " + Child.counter);
                child.CountChild();
                Console.WriteLine(Parent.counter + " " + Child.counter);

                //섀도잉
                int number = 20;
                Console.WriteLine(number);

                //하이딩
                Child c=new Child();
                Console.WriteLine(c.variable);
                Console.WriteLine(((Parent)c).variable);
                c.Method();
                ((Parent)c).Method();
            }
        }
    }
     
    
}
