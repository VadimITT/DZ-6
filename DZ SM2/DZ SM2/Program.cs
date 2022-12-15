Console.WriteLine($"Введите число "); 
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число ");
int b = Convert.ToInt32(Console.ReadLine());
    if (a/b==0)   
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("не кратно, остаток"+ a % b);
}