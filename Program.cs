int GetSum(int n)
{
    int sum = 0;
    while(n > 0)
    {
        int result = n % 10;
        sum = sum + result;
        n = n / 10;
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {n} равна {GetSum(n)}");