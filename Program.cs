//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*double longLineAB (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double longLine = Math.Sqrt((xB - xA)*(xB -xA)+(yB - yA)*(yB - yA)+(zB - zA)*(zB - zA));
    longLine = Math.Round(longLine, 2);
    return longLine;
}

Console.WriteLine("Input X coord of A: ");
int XcoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coord of A: ");
int YcoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coord of A: ");
int ZcoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coord of B: ");
int XcoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coord of B: ");
int YcoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coord of B: ");
int ZcoordB = Convert.ToInt32(Console.ReadLine());

double dist = longLineAB (XcoordA, XcoordB, YcoordA, YcoordB, ZcoordA, ZcoordB);
Console.WriteLine($"Distance between A and B is {dist}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*
void SquarePrinter (int numberN)
{
    int current = 1;
    while (current <= numberN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}
Console.WriteLine("Input N: ");
int user_number = Convert.ToInt32(Console.ReadLine());
SquarePrinter(user_number);
*/

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*
Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());


int result1 = num%10;
int result2 = (num/10)%10;

int result4 = (num/1000)%10;
int result5 = (num/10000)%10;


    if (num < 100000 && num > 9999)
    {
        if (result1 == result5 && result2 == result4)
        {
            Console.WriteLine("да");
        }
    else 
    {
        Console.WriteLine("нет");
    }
    }
    */