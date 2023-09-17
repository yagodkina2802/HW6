// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
int WorkWithUser(string mes)
{
    Console.WriteLine(mes);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = WorkWithUser("Введите чило:");
        
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


void SearchPositiveValue(int[] array)
{
    int count = 0;
    foreach (int ell in array)
    {
        if(ell>0) count++;
    }
    Console.WriteLine(count);
}


int length = WorkWithUser("Введите длину массива:");
int[] array = FillArray(length);
PrintArray(array);
Console.WriteLine();
SearchPositiveValue(array);