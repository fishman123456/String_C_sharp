﻿// со
using System.Linq.Expressions;

Console.ReadLine();
Console.WriteLine("Введите Фамилия ");
string soname = Console.ReadLine();
Console.WriteLine("Введите Имя ");
string name = Console.ReadLine();
Console.WriteLine("Введите Отчество ");
string patronymic = Console.ReadLine();
int var1 = 0;
int var2 = 0;
Console.WriteLine("Введите чередование 1 - Фамилия ");
Console.WriteLine("Введите чередование 2 - Имя ");
Console.WriteLine("Введите чередование 3 - Отчество ");
Console.WriteLine("Введите чередование 4 - ФИО ");
Console.WriteLine("Введите чередование 9 - Выход ");
Console.WriteLine("Введите чередование 0 - Очистка экрана ");
//Console.WriteLine(name);
//Console.WriteLine(soname);
//Console.WriteLine(patronymic);
//Console.WriteLine("Введите порядок вывода данных");
//Console.WriteLine("1 ФИО");
//Console.WriteLine("2 ИФО");
//Console.WriteLine("1 ФИ");
do
{
    Console.WriteLine("Выберите режим вывода");
    var1 = Int32.Parse(Console.ReadLine());
    switch (var1)
    {
        case 0:
            Console.Clear();
            break;    
        case 1:
            Console.WriteLine(soname);
            break;
        case 2:
            Console.WriteLine(name);
            break;
        case 3:
            Console.WriteLine(patronymic);
            break;
        case 4:
            Console.WriteLine(soname);
            
            Console.WriteLine(name);
            
            Console.WriteLine(patronymic);
            
            break;

        case 5:
            Console.WriteLine("Введите чередование 1 - Фамилия ");
            Console.WriteLine("Введите чередование 2 - Имя ");
            Console.WriteLine("Введите чередование 3 - Отчество ");
            Console.WriteLine("Введите чередование 4 - ФИО ");
            Console.WriteLine("Введите чередование 9 - Выход ");

            Console.WriteLine("Введите чередование 0 - Очистка экрана ");
            break;
        case 9:
            break;
        default:
            break;
    }
} while (var1 != 9);