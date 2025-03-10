using System;
using System.Security.Cryptography.X509Certificates;
namespace HW_2_5;

class Program
{
    static void Main(string[] args)
    {
        // дз 3
        // 1
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Введите первое число :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число :");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = a+b;
        Console.WriteLine(sum);
        // 2 
        Console.WriteLine("Игра угадай число");
        bool flag = true;
        int x = 12;
        while (flag){
            Console.WriteLine("Введите число :");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == x){
                Console.WriteLine("Вы угадали !");
                flag = false;
            }
            else if(y < x){
                Console.WriteLine("Попробуйте увеличить число !");
            }
            else if(y>x){
                Console.WriteLine("Попробуйте уменьшить число !");
            }
        }

    }
}
