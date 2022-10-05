// Task_9 Удалить вторую цифру трёхзначного числа
int a = new Random().Next(100, 1000);
String number = Convert.ToString(a);
char n0 = number[0];
char n1 = number[2];
Console.WriteLine(a);
Console.WriteLine((n0.ToString()) + (n1.ToString()));

