internal partial class Program
{
    public static void Main(string[] args)
    {
        string Input(string text)
        {
            Console.Write($"{text} ");
            return Console.ReadLine();
        }

        void PrintNaturalNumbers(int n)
        {
            if (n != 1)
            {
                PrintNaturalNumbers(n - 1);
            }
            Console.Write($"{n} ");
        }

        void PrintInterval(int m, int n)
        {
            Console.Write($"{m} ");
            if (m < n)
            {
                PrintInterval(m + 1, n - 1);
                Console.Write($"{n} ");
            }


        }

        int SummNum(int number)
        {
            if (number > 0)
            {
                return number % 10 + SummNum(number / 10);
            }
            return number % 10;
        }

        int ExponentiationNum(int a, int b)
        {           
            if (b>0)
            {
                return a * ExponentiationNum(a, b - 1);
            }
            return 1;
        }

        // Задача 63. Задайте значение N. Напишите программу, которая
        // выведет все натуральные числа в промежутке от 1 до N.

        void Task63()
        {
            int n = Convert.ToInt32(Input("Введите число: "));
            PrintNaturalNumbers(n);
        }
        // Task63();

        // Задача 65. Задайте значения M и N. Напишите программу, которая
        // выведет все натуральные числа в промежутке от M до N.

        void Task65()
        {
            int m = Convert.ToInt32(Input("Введите число M: "));
            int n = Convert.ToInt32(Input("Введите число N: "));
            PrintInterval(m, n);
        }
        // Task65();

        // Задача 67. Напишите программу, которая будет принимать
        // на вход число и возвращать сумму ее цифр.

        void Task67()
        {
            int number = Convert.ToInt32(Input("Введите число: "));
            Console.WriteLine(SummNum(number));
        }
        // Task67();

        // Задача 69. Напишите программу, которая принимает на вход два числа A и B, 
        // и возводит число А в целую степень В с помощью рекурсии.

        void Task69()
        {
            int a = Convert.ToInt32(Input("Введите число A: "));
            int b = Convert.ToInt32(Input("Введите число B: "));
            Console.WriteLine($"Число А в степении В равно {ExponentiationNum(a, b)}.");
        }
        Task69();


    }
}