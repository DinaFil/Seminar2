Console.WriteLine("Пожалуйста, введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int remainder = number1 % number2;
if (remainder == 0) Console.WriteLine("Первое число кратно второму числу");
else Console.WriteLine($"Первое число не кратно второму, остаток {remainder}");














