// Task_10 Выяснить, кратно ли число заданному, если нет, вывести остаток.
int a = new Random().Next(11, 100);
int div = new Random().Next(0, 10);

Console.WriteLine(a + " / " + div);

if(a%div == 0)
{
    Console.WriteLine("without remainder");
}
else
{
    Console.WriteLine("remainder " + a%div);
}
