// задача № 25. Программа принимает два числа а и б. После чего возводит число А в степень Б

int exponen(int a, int b)
{
    int sum = (int)Math.Pow(a, b);
    Console.WriteLine("Число А в степени Б = " +sum);

    return sum;
}
exponen(Convert.ToInt32(Console.ReadLine()),
        Convert.ToInt32(Console.ReadLine()));