using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExpressionsApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Условные выражения
            // Операции сравнения

            int a = 10;
            int b = 4;
            bool c = a == b; // false операция равенства

            bool d = a != b; // true операция неравенства

            // < > <= >=
            bool f = a > b; // true

            bool e = a < b; // false

            bool g = a <= b; // true

            bool h = a <= 10; // true

            // Логические операции

            // | || & && ! ^ сложение/амперсанд - умножение/отрицание/исключающее или
            bool x1 = (5 > 6) | (4 < 6); // false | true - true
            bool x2 = (5 > 6) | (4 > 6); // false | false - false

            bool x3 = (5 > 6) & (4 < 6); // false | true - false
            bool x4 = (5 > 6) & (4 > 6); // false | false - false
            bool x5 = (5 < 6) & (4 < 6); // true | true - true

            // для оптимизации лучши использовать || && вычитается только первый 

            bool t = true;
            bool s = !t; // true

            bool x6 = (5 > 6) ^ (4 < 6); // false | true - true
            bool x7 = (5 > 6) ^ (4 > 6); // false | false - false

            Console.ReadKey();
        }
    }
}
