// Task_3 Найти максимальное из трех чисел
int a = new Random().Next(0, 100), b = new Random().Next(0, 100), c = new Random().Next(0, 100);
int max = a;

if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

Console.WriteLine("largest among numbers " + a + ", " + b + ", " + c + " is " + max);

