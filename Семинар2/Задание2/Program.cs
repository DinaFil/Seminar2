Random random = new Random();
int number = random.Next(100,1000);
Console.WriteLine(number);
int a = number / 100;
int b = number % 10;

Console.WriteLine($"Двухзначное числое {a}{b}");

