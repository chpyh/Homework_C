//Задача 1
Console.Clear();
Console.Write("Введите  число: ");
int n = int.Parse(Console.ReadLine()!);
if(n % 7 ==0 && n % 23 == 0)
{
Console.WriteLine($"{n} является числом, одновременно кратным и 7, и 23 ");
}
else
{
    Console.WriteLine($"{n} не является числом, одновременно кратным и 7, и 23");
}
