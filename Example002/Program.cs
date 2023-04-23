// Рекурсия
// Факториал

// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine($"Факториал числа равен {Factorial(3)}.");

// Фибоначи

int Fibonacci(int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

Console.Write("Последовательность Фибоначчи ");
for (int i = 1; i < 10; i++)
{
        Console.Write($"{Fibonacci(i)}, ");
}