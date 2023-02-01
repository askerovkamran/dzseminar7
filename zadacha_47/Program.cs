// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] array = GetArray(rows, columns, -10, 10); 
PrintArray(array);

// -----------------Метод-------------------------


double[,] GetArray(int m, int n, int minValue, int maxValue) {
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        result[i, j] = new Random().NextDouble()*(maxValue-minValue);
    }
    }
    return result;
}

void PrintArray(double[,] inArray){
    for(int i = 0; i < inArray.GetLength(0); i++){
        for(int j = 0; j < inArray.GetLength(1); j++){
            Console.Write($"{inArray[i,j] :f1}");
        }
        Console.WriteLine();
    }
}