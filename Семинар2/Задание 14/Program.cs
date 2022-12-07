Console.WriteLine("Пожалуйста, введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int remainder1 = number1 % 7;
int remainder2 = number1 % 23;
if (remainder1 == 0 && remainder2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");


