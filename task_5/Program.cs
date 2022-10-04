// Task_5 Показать четные числа от 1 до N
int count = 1;
int n = new Random().Next(0, 10);

Console.WriteLine(n);

while(n >= count)
{
    Console.Write(count + " ");
    count++;
}

