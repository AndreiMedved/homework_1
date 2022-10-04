// Task_6 Показать последнюю цифру трёхзначного числа
int a = new Random().Next(100, 1000);
string number = Convert.ToString(a);
char last = number[2];
Console.WriteLine(a);
Console.WriteLine(last);

