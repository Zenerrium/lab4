Console.WriteLine("Введите количество чисел");
int n = Convert.ToInt32(Console.ReadLine());
double a;
int s = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число:");
    a = Convert.ToDouble(Console.ReadLine());
    if (a%2 !=0)
    {
        s++;
    }
}
Console.WriteLine(s);