// задача 27. Програама принимает число. И выдает сумму цифр.
Console.Write("Введите число X: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = 0;
while(n!=0)
{
    s = s + n % 10;
    n = n / 10;
}
if(n == 0)
{
    Console.WriteLine("Нечего складывать!");
}
Console.WriteLine("---------------------------");
Console.WriteLine("Сумма чисел равна: {0}",s);


