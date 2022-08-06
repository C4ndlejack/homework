Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.WriteLine("Все чётные числа в диапазоне: ");
while (count<=n)
{
    if(count % 2 == 0)
    {
        Console.Write(count + ", ");
        count += 1;
    }
    else
    {
        count += 1;
    }
}
