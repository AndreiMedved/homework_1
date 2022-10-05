// Task_8 Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10, 100);
string number = Convert.ToString(a);
char first = number[0];
char second = number[1];
Console.WriteLine(a);

if(first > second)
{
    Console.WriteLine(first);
}
if(second > first)
{
    Console.WriteLine(second);
}
else
{
    Console.WriteLine("similar numbers");
}