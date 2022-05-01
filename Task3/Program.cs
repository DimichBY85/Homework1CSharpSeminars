Console.Write("Введите число, чтобы узнать четное оно или нет: ");
int num = int.Parse(Console.ReadLine());
int remain = num % 2;
if (remain == 0) Console.WriteLine("Число " + num + " четное!");
else Console.WriteLine("Число " + num + " нечетное!");
