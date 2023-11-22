//Задача 1
/*Console.Clear();
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
*/
// Задача 2
Console.Clear();
Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine()!);
while(X == 0)
{
    Console.Write("Введите координату X: ");
    X = int.Parse(Console.ReadLine()!);
}
Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);
while(Y == 0)
{
    Console.Write("Введите координату Y: ");
    Y = int.Parse(Console.ReadLine()!);
}

if(X > 0 && Y > 0)
{
    Console.WriteLine("I");
}
else if(X < 0 && Y > 0)
{
  Console.WriteLine("II");  
}
else if(X < 0 && Y <0)
{
  Console.WriteLine("III");  
}
else
{
    Console.WriteLine("IV");  
}
