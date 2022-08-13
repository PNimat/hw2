// Задача 10
/*
Console.WriteLine("Введите трехзначное число");
int i = Convert.ToInt32(Console.ReadLine());

if (i>=100 && i<=999)
{

int y = i%100;
int u = y/10;
Console.WriteLine(u);

} else 
{
    Console.WriteLine("Число не трехзначное");
}
*/

// Задача 13
/*
Console.WriteLine("Введите число");
int i13 = Convert.ToInt32(Console.ReadLine());
if (i13>99) 
{
    string str = Convert.ToString(i13);
    char t = str[2];
    Console.WriteLine(t);
} else 
{
    Console.WriteLine("Число не трехзначное");
}
*/

// Задача 15
Console.WriteLine("Введите число");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(l);
if (l<1 || l>7)
{
    Console.WriteLine("Число не подходит");
} else if (l>0 && l<6) 
{
    Console.WriteLine("Рабочий день");
} else if (l>5 && l<8)
{
    Console.WriteLine("Выходной день");
}
