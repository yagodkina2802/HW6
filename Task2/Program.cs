// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int WorkWithUser(string mes)
{
    Console.WriteLine(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int y = k1 * x + b1;
int y = k2 * x + b2;


int k1 = WorkWithUser("Введите точку k1: ");
int b1 = WorkWithUser("Введите точку b1: ");
int k2 = WorkWithUser("Введите точку k2: ");
int b2 = WorkWithUser("Введите точку b2: ");