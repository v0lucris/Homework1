// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введи первое число : ");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число : ");
int a2 = int.Parse(Console.ReadLine());
if (a1 == a2 * a2)
{
    Console.WriteLine("Первое является квадратом второго");
}
else
Console.WriteLine("Первое НЕ является квадратом второго");
