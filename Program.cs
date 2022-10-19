
// Задача 10. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
Console.Write("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 0;
int number3 = 0;

if(number < 1000)
{
    number2 = number/10;
    number3 = number2%10;
    Console.WriteLine(number3);
}
else
{
     Console.WriteLine("число нетрехзначное");
}
*/

// вариант решения 2

/* Console.Write("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1000)
{
string str = number.ToString();
Console.WriteLine(str[1]);
}
else
{
     Console.WriteLine("число нетрехзначное");
}
*/

// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 100)
{
string str = number.ToString();
Console.WriteLine(str[2]);
}
else
{
Console.WriteLine("третьей цифры нет");
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите номер дня недели");
string str = Console.ReadLine();
int num = int.Parse(str);
int [] array = { 1, 2, 3, 4, 5, 6, 7 };

if(num == array [5])
{
Console.WriteLine("выходной");
}

if(num = array [6])
{
Console.WriteLine("выходной");
}

else
{
    Console.WriteLine("рабочий день");
}

/* 
Console.WriteLine("введите число дня недели");
int b = Convert.ToInt32(Console.ReadLine());
switch (b)
{
    case 1:
     Console.WriteLine("рабочий день");
    break;

    case 2:
     Console.WriteLine("рабочий день");
    break;

    case 3:
     Console.WriteLine("рабочий день");
    break;

    case 4:
     Console.WriteLine("рабочий день");
    break;

    case 5:
     Console.WriteLine("рабочий день");
    break;

    case 6:
     Console.WriteLine("выходной");
    break;

    case 7:
     Console.WriteLine("выходной");
    break;

    default:
    Console.WriteLine("неверное число");
    break;
}
*/

