using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        //Tinh ke thua
        class Person//Lop co so Person
        {
            protected int age;
            public void LoiChao()
            {
                Console.WriteLine("Hello oop");
            }
            public void SetAge(int n)
            {
                age = n;
            }
        }
        class Student : Person//Lop dan xuat Student ke thua lop cha Person
        {
            public void ThongBaoTuoi()
            {
                Console.WriteLine("Tuoi cua ban la: {0} tuoi", age);
            }
        }
        class Teacher : Person//Lop dan xuat Teacher ke thua lop cha Person
        {
            private string mon_hoc;

            public string getMonHoc()
            {
                return mon_hoc;
            }
            public void setMonHoc(string mon)
            {
                this.mon_hoc = mon;
            }
            public void GiangDay()
            {
                Console.WriteLine("Bat dau giang day!!!");
            }
        }

        class Animal
        {
            public int legs { get; set; }
            public int weight { get; set; }
            protected int sex { get; set; }//Protected chi co the goi o trong class va class ke thua no
            public void ShowLegs()
            {
                Console.WriteLine($"Legs: {legs}\nSex: {sex}");
            }

        }

        class Cat : Animal
        {
            public string food;
            public Cat()
            {
                sex = 0;
                legs = 4;
                food = "Mouse";
            }    

            public void Eat()
            {
                Console.WriteLine("Meal");
            }
        }

        interface Iorder//co the implement nhieu interface trong c#, c# khong co tinh da ke thua
        {
            void showPrice();
        }

        abstract class Product:Iorder//Lop ao procduct khong the dung lop nay de khai bao 
        {
            protected double price = 0;

            public virtual void ProductInfo()//Phuong thuc ao 
            {
                Console.WriteLine($"Gia san pham {price}");
            }

            public void showPrice()
            {
                Console.WriteLine($"Gia san pham {price}");
            }

            public void TestProduct()
            {
                this.ProductInfo();
            }
        }

        class Iphone : Product
        {
            public Iphone()
            {
                price = 500;
            }
            public override void ProductInfo()//override lai phuong thuc ao 
            {
                Console.WriteLine($"Dien thoai Iphone");
                base.ProductInfo();//Goi lai phuong thuc ao o lop cha
            }
        }
        class Laptop:Product
        {
            public Laptop()
            {
                price = 450;
            }
            public override void ProductInfo()
            {
                Console.WriteLine("Lap top");
                base.ProductInfo();
            }
        }



        static void Main(string[] args)
        {
            int s = 1000;
            Product p1 = new Laptop();
            Product p2 = new Iphone();
            p1.showPrice();
            p1.TestProduct();   
            p2.TestProduct();  
            //Cat cat =new Cat();
            //cat.ShowLegs();

            //cat.Eat();
            //bool debug = false;

            //Console.WriteLine("\nLap trinh huong doi tuong trong C#");
            //Console.WriteLine("----------------------------------\n");
            ////tao doi tuong Person va goi phuong thuc Greet()
            //Person myPerson = new Person(); //day la constructor mac dinh
            //myPerson.LoiChao();

            ///*tao mot doi tuong Student, thiet lap tuoi cho sinh vien nay la 21, 
            //  gui loi chao toi anh ta va thong bao tuoi*/
            //Student myStudent = new Student(); //day la constructor mac dinh
            //myStudent.SetAge(21);
            //myStudent.LoiChao();
            //myStudent.ThongBaoTuoi();

            ///*tao mot doi tuong Teacher, thiet lap tuoi cho giang vien nay la 30, 
            // *de nghi anh ta chao va bat dau giang day*/
            //Teacher myTeacher = new Teacher(); //day la constructor mac dinh
            //myTeacher.SetAge(30);
            //myTeacher.LoiChao();
            //myTeacher.GiangDay();

            //if (debug)
            //    Console.ReadLine();

            Console.ReadKey();
        }
    }
}
