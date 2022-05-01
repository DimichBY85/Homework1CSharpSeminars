Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int remain = 2;

while (num >= remain)
{
    Console.Write(remain + " ");
    remain = remain + 2;
}