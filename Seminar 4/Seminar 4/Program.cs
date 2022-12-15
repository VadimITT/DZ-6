Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int getcounte (int a)
{
    int resoult = 0;    

    while (a>0)
    {
        resoult++;
        a /= 10;
    }
return resoult;
}
Console.WriteLine(getcounte(a));