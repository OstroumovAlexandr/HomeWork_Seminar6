// Задача 1:

// Проверка на палиндромность 5-ти значного числа
/*
Console.Write("Введи пятизначное число: ");
int number = int.Parse(Console.ReadLine()!); // поэтому преобразуем введенные значения в цифры
string Num = Convert.ToString(number); // 1-ый способ КОНВЕРТИРОВАНИЯ переменной "int number" в "string number"
if(Num.Length == 5)
{
    if((Num[0] == Num[4]) && (Num[1] == Num[3]))
    {
    Console.WriteLine($"Введенное число {Num} является палиндромом.");
    }
    else{
       Console.WriteLine($"Введенное число {Num} НЕ является палиндромом."); 
    }
}
else{
    Console.WriteLine($"Введите ПЯТИЗНАЧНОЕ !!! число");
}

*/



// Задача 2 
// Нахождене расстояния между двумя точками в 3D простарнстве
/*
Console.WriteLine("Введите координату Х точки А: ");
int xa = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки A: ");
int ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки A: ");
int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату x точки b: ");
int xb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки B: ");
int yb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки B: ");
int zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2));

Console.WriteLine($"Расстояние между точками: {result:f2}"); // {result:f2} после двоеточия стоит конструкция, 
                                                            // которая определяет количество выводимых знаков после запятой. 
                                                           // 2 - означает два знака

*/






// Задача 3

// Таблица кубов чисел от 1 до N
/*
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

for(int i = 1; i <= n; i++)
{
    Console.Write($"{Math.Pow(i,3)} ");
}

*/
