// Task_11 Найти третью цифру числа или сообщить, что её нет
int a = new Random().Next(95, 105);
String number = Convert.ToString(a);
char n0 = number[0];
char n1 = number[1];


Console.WriteLine(a);

if (a < 100)
{
    Console.WriteLine("There's not third number in the " + number);
}
else
{
    char n2 = number[2];
    Console.WriteLine(n2.ToString());
}
