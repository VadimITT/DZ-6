Random rnd = new Random();
int number = rnd.Next(100, 1000);
Console.WriteLine(number);
int firstNumber = number / 100;
int SecondNumber = number % 10;
Console.WriteLine(firstNumber*10 + SecondNumber);