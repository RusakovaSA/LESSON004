// Рекурсия

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine($"Факториал числа равен {Factorial(3)}.");