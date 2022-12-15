void Reverse(int[] massiv)
{
    for (int i = 0; i < massiv.Length/2; i++)
    {
        ChangeElement(massiv, i,massiv.Length-1-i);
    }

}


int[] Massiv(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i<lenght; i++)
    {
        array[i] = i;
    }
    return array;
}

string GetArrayAsString(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]},  ";
    }
    return result;
}

void ChangeElement(int[] massive, int indexOne,int indexTwo)
{
    int temp = massive[indexOne]; massive[indexOne] = massive[indexTwo]; massive[indexTwo]=temp;
}
Console.WriteLine();

int[] array = Massiv(10);
Console.WriteLine(GetArrayAsString(array));
Reverse(array);
Console.WriteLine(GetArrayAsString(array));