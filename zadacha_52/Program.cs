// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array);
double[] Columns=GetResultArray(array);
Console.WriteLine($"Среднее арифмитическое: = {String.Join(";", Columns)}");


// -----------------Метод-------------------------

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


double[] GetResultArray(int[,]  array) 
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum=0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum+=array[j,i];
        }
        result[i]=Math.Round(sum/array.GetLength(0), 2);
    }
    return result;
}

void PrintArray(int[,] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++){
        for(int j = 0; j < inArray.GetLength(1); j++){
            Console.Write($"{inArray[i,j]}");
        }
        Console.WriteLine();
    }
}