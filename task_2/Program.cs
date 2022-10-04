// Task_2 По заданному номеру дня недели вывести его название
string mon = "monday", tue = "tuesday", wed = "wednesday", thu = "thursday", fri = "friday", sat = "saturday", sun = "Sunday";
int week = new Random().Next(0, 7);

Console.Write(week + " ");
if(week == 0)
{
Console.WriteLine(mon);
}
if(week == 1)
{
Console.WriteLine(tue);
}
if(week == 2)
{
Console.WriteLine(wed);
}
if(week == 3)
{
Console.WriteLine(thu);
}
if(week == 4)
{
Console.WriteLine(fri);
}
if(week == 5)
{
Console.WriteLine(sat);
}
if(week == 6)
{
Console.WriteLine(sun);
}
