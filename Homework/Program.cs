// Задача 54 начало
// Заполнения массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Сортировка элементов в строке двумерного массива
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Задача 54 конец


// Задача 56 начало
// Печать массива
void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Заполнение массива
void FillArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Поиск номера строки с наименьшей суммой элементов 
void NumberRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}
// Задача 56 конец


// Задача 58 начало
    // Уможение матриц
    void CalculateMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
    {
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
        int sum = 0;
        for (int k = 0; k < firstMartrix.GetLength(1); k++)
        {
            sum += firstMartrix[i,k] * secomdMartrix[k,j];
        }
        resultMatrix[i,j] = sum;
        }
    }
    }

    // Ввод значений матриц
    int InputNum(string input)
    {
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
    }

    // Заполнение массива
    void FillArray3(int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(1, 10);
        }
    }
    }

    // Печать массива
    void PrintArray3 (int[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    }
// Задача 58 конец


// Задача 62 начало

//Печать массива по кругу
void PrintArray4 (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
// Задача 62 конец

Console.Clear();
Console.WriteLine("\n========= Список задач ==========\n");
Console.WriteLine("1 - Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("2 - Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("3 - Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.WriteLine("4 - Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
Console.WriteLine("0 - Выход\n");
Console.Write("Выберите задачу 1, 2, 3 или 4:   ");
int task = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (task)
{
    case 1:
        // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 7 4 2 1
        // 9 5 3 2
        // 8 4 4 2

        int[,] table = new int[3, 4];
        FillArray(table);
        PrintArray(table);
        SortArray(table);
        Console.WriteLine();
        PrintArray(table);
        break;


    case 2:
        // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

        int[,] table2 = new int[4, 4];
        FillArray2(table2);
        PrintArray2(table2);
        Console.WriteLine();
        NumberRow(table2);
        break;


    case 3:
        // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        // Например, даны 2 матрицы:
        // 2 4 | 3 4
        // 3 2 | 3 3
        // Результирующая матрица будет:
        // 18 20
        // 15 18

        Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
        int m = InputNum("Введите число строк 1-й матрицы: ");
        int n = InputNum("Введите число столбцов 1-й матрицы (и строк 2-й): ");
        int p = InputNum("Введите число столбцов 2-й матрицы: ");
        int range = InputNum("Введите диапазон случайных чисел: от 1 до ");

        int[,] firstMartrix = new int[m, n];
        FillArray3(firstMartrix);
        Console.WriteLine($"Первая матрица:");
        PrintArray3(firstMartrix);

        int[,] secomdMartrix = new int[n, p];
        FillArray3(secomdMartrix);
        Console.WriteLine($"Вторая матрица:");
        PrintArray3(secomdMartrix);

        int[,] resultMatrix = new int[m,p];
        CalculateMatrix(firstMartrix, secomdMartrix, resultMatrix);
        Console.WriteLine($"Произведение первой и второй матриц:");
        PrintArray3(resultMatrix);
        break;    


    case 4:
        // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
        // Например, на выходе получается вот такой массив:
        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07

        int t = 4;
        int[,] sqareMatrix = new int[t, t];
        int temp = 1;
        int i = 0;
        int j = 0;

        //Заполнение массива
        while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
        {
            sqareMatrix[i, j] = temp;
            temp++;
            if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
                j--;
            else
                i--;
        }

        PrintArray4(sqareMatrix);
        break;


    case 0:
        Console.WriteLine("Всего хорошего!");
        break;
}
Console.WriteLine();