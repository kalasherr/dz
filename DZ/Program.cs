using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            double e = Math.E;
            e = Math.Round(e, 1);//округление до 1 знака после запятой
            Console.WriteLine(e);
            

            Console.WriteLine("Задание 2");
            Console.WriteLine("10");
            Console.WriteLine("50");
            

            Console.WriteLine("Задание 3.1");//вариант на случай, если нужно было сделать ввод-вывод
            Console.Write("Введите 1ое число:");
            string s1 = (Console.ReadLine());
            Console.Write("Введите 2ое число:");
            string s2 = Console.ReadLine();
            Console.Write("Введите 3е число:");
            string s3 = Console.ReadLine();
            Console.Write("Введите 4ое число:");
            string s4 = Console.ReadLine();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);


            Console.WriteLine("Задание 3.2");// на случай если нужны рандомные числа
            var r1 = new Random(); 
            // for (int i = 0; i <= 3; i++)
            Console.WriteLine(r1.Next());
            Console.WriteLine(r1.Next());
            Console.WriteLine(r1.Next());
            Console.WriteLine(r1.Next());
            Console.WriteLine("Заданиe 4");
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine();
            int number1 = Convert.ToInt32(number);
            number1 = number1 + 10;
            Console.WriteLine(number1);
            Console.ReadKey();


            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите сторону:");
            int storona = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(storona*4);
            Console.ReadKey();


            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите радиус");
            double radius =Convert.ToDouble(Console.ReadLine());
            double area = radius * radius * Math.PI;
            double lenght = radius * 2 * Math.PI;
            Console.Write("S=");
            Console.WriteLine(area);
            Console.Write("l=");
            Console.WriteLine(lenght);
            Console.ReadKey();


            Console.WriteLine("Задание 7");
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(x);
            Console.Write("y=");
            Console.WriteLine(y);


            Console.WriteLine("Задание 8");
            Console.Write("Введите первое основание");
            double osnovanie1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе основание:");
            double osnovanie2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Convert.ToString(osnovanie1 + osnovanie2 +height+ Math.Sqrt((osnovanie1 - osnovanie2) * (osnovanie1 - osnovanie2) + height * height)));
            Console.ReadKey();


            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите стоимость и кол-во каждого продукта в порядке стоимость1-масса1-стоимость2-масса2-...");
            double candy_price = Convert.ToDouble(Console.ReadLine());
            double candy_weight = Convert.ToDouble(Console.ReadLine());
            double cookies_price = Convert.ToDouble(Console.ReadLine());
            double cookies_weight = Convert.ToDouble(Console.ReadLine());
            double apple_price = Convert.ToDouble(Console.ReadLine());
            double apple_weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сумма:");
            Console.WriteLine(candy_price * candy_weight + cookies_price * cookies_weight + apple_price * apple_weight);
            Console.ReadKey();


            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Задание 2");
            Console.ReadKey();
        }
    }
}
