
Console.Write("Введите число N: ");
int [] array(int n)
{
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        int newNumb = (new Random()).Next(0,99);
        result[i] = newNumb;
        Console.Write(result[i] + " ");
    }

    return result;

}

array(Convert.ToInt32(Console.ReadLine()));