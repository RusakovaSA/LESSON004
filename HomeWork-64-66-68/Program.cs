
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
            Console.Write($"{n}, ");
            if (n != 1)
            {
                PrintNaturalNumbers(n - 1);
            }
        }

        int SummElements(int m, int n)
        {
            if (n!=m)
            {
                return m + SummElements(m+1, n);
            }
            return m;
        }

        int Akkerman(int m, int n)
        {            
            if(m==0)
            {
                return n+1;
            }
            else if(m>0 && n==0)
            {
                return Akkerman(m-1,1);
            }
            else return Akkerman(m-1, Akkerman(m, n-1));
        }

        // Задача 64: Задайте значение N. Напишите программу, которая выведет 
        // все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
        // N = 5 -> "5, 4, 3, 2, 1"
        // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

        void Task64()
        {
            int n = Convert.ToInt32(Input("Задайте значение N: "));
            PrintNaturalNumbers(n);
        }
        // Task64();


        // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
        //  сумму натуральных элементов в промежутке от M до N.
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30

        void Task66()
        {
            int m = Convert.ToInt32(Input("Задайте значение M: "));
            int n = Convert.ToInt32(Input("Задайте значение N: "));
            Console.WriteLine(SummElements(m, n));

        }
        // Task66();

        // Задача 68: Напишите программу вычисления функции Аккермана 
        // с помощью рекурсии. Даны два неотрицательных числа m и n.
        // m = 2, n = 3 -> A(m,n) = 9
        // m = 3, n = 2 -> A(m,n) = 29

        void Task68()
        {
            int m = Convert.ToInt32(Input("Задайте положительное значение M: "));
            int n = Convert.ToInt32(Input("Задайте положительное значение N: "));
            Console.WriteLine(Akkerman(m, n));
        }
        // Task68();
    }
}