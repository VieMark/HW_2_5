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
        Console.WriteLine("Сумма чисел :");
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

        // ДЗ 4
        // 1
        int[] M1 = [ 1, 88, 3, 99 ];
        int[] M2 = [ 2, 5, 11, 123, 77 ];
        int[] massiv = M1.Concat(M2).ToArray();
        foreach(int i in massiv){
            Console.WriteLine(i);
        }
        
        //2
        // Честно посмотрела в интернете, но всё равно не поняла, как это сделать. 

        // ДЗ 5
        int m = 0 ;
        int[] list = [ 1, 88, 3, 99, 2, 2, 2, 3, 44, 5, 3, 5, 100, 2, 33, 55, -1, -123 ];
        
            

    }
}
