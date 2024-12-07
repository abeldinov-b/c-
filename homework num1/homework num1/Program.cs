using System;
 
namespace HelloPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);



            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1+num2);



            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите первое число");
            int num11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num22 = Convert.ToInt32(Console.ReadLine());
            if (num11 > num22)
            {
                Console.WriteLine(num11 - num22);
            }
            else if (num11 < num22) 
            {
                Console.WriteLine(num22 - num11);
            }



            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите свой возвраст");
            int  age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Прожито лет");
            Console.WriteLine(age);
            Console.WriteLine("Прожито месяцев");
            Console.WriteLine(age*12);
            Console.WriteLine("Прожито недель");
            Console.WriteLine(age*52);
            Console.WriteLine("Прожито дней");
            Console.WriteLine(age*365);
            Console.WriteLine("Прожито часов");
            Console.WriteLine(age * 8760);
            Console.WriteLine("Прожито минут");
            Console.WriteLine(age*525600);
            Console.WriteLine("Прожито секунд");
            Console.WriteLine(age*31536000);



            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число которое хотите проверить на положительность или отрицательность");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Это число положительное");
            }
            else if(num < 0)
            {
                Console.WriteLine("Это число отрицательное");
            }
        }
    }
}