Console.WriteLine("Введите количество чисел");
int n = Convert.ToInt32(Console.ReadLine());
double a;
int s = 0;
int i = 0;
while (i < n)
{
    Console.WriteLine("Введите число:");
    a = Convert.ToDouble(Console.ReadLine());
    if (a%2 !=0)
    {
        s++;
    }
    i++;
}
Console.WriteLine(s);
