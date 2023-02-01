// Задача 50. Напишите программу, которая на вход принимает число, 
// проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, 
// что оно найдено или же указание, что такого элемента нет.

Console.Write("Введите количество строк: ");
int rows=int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns=int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array);
Console.Write("Введите значение элемента: ");
int element=int.Parse(Console.ReadLine()!);
if(Element(array, element))
{
    Console.WriteLine("Элемент найден");

}
else 
{

    Console.WriteLine("Элемент не найден");
}


// // -----------------Метод-------------------------


int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
    for(int j = 0; j < n; j++)
    {
        result[i, j] = new Random().Next(minValue, maxValue+1);
    }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}");
        }
        Console.WriteLine();
    }
}
bool Element(int[,] array, int el)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]==el) return true;
        }
    }
    return false;
}