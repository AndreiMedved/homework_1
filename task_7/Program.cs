// Task_7 Показать вторую цифру трёхзначного числа
int a = new Random().Next(100, 1000);
string number = Convert.ToString(a);
char second = number[1];
Console.WriteLine(a);
Console.WriteLine(second);
