Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > max) max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);
