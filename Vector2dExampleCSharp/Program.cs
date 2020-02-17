using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2dExampleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2d a=new Vector2d(3, 5);
            Console.WriteLine("Вектор a:");
            Console.Write("Введите координату x:");
            a.SetX();
            Console.Write("Введите координату y:");
            a.SetY();
            Vector2d b=new Vector2d(4, 8);
            Console.WriteLine("Вектор b:");
            Console.Write("Введите координату x:");
            b.SetX();
            Console.Write("Введите координату y:");
            b.SetY();
            Vector2d c = a + b;
            Console.Write("Сложение векторов:");
            c.Print();
            c = a - b;
            Console.Write("Разность векторов:");
            c.Print();
            double scal = a / b;
            Console.Write("Скалярное произведение векторов:");
            Console.WriteLine(scal.ToString());
            /*double chax=a.GetX();
            double chay=a.GetY();
            Console.WriteLine(chax.ToString());
            Console.WriteLine(chay.ToString());*/
            Console.WriteLine("Умножение вектора b на число");
            Console.Write("Введите число:");
            double ch = double.Parse(Console.ReadLine());
            c = b * ch;
            Console.Write("Результат умножения:");
            c.Print();
            double tangens=a.tanAngle(b);
            Console.Write("Тангенс угла между векторами:");
            Console.WriteLine(tangens.ToString());
            /*chax = a.GetX();
            chay = a.GetY();
            Console.WriteLine(chax.ToString());
            Console.WriteLine(chay.ToString());*/
            c++;
            Console.Write("Инкремент:");
            c.Print();
            c--;
            Console.Write("Декремент:");
            c.Print();
            c += b;
            Console.Write("Увеличение на координаты вектора b:");
            c.Print();
            c -= a;
            Console.Write("Уменьшение на координаты вектора a:");
            c.Print();
            Console.WriteLine("Умножение вектора на число");
            Console.Write("Введите число:");
            ch = double.Parse(Console.ReadLine());
            c *= ch;
            Console.Write("Результат умножения:");
            c.Print();
            Console.ReadKey();
        }
    }
}
