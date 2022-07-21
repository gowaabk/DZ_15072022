/* Задача 2: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);

        }
    }
    return answer;
}

int FindMax(int[] array)           //функция поиска строки с наименьшей суммой
{
    int numRow = 0;
    int min = array[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            numRow = i;
        }
    }
    return numRow;
}

int[] SumRows(int[,] array, int rows)           //функция поиска сумм строк в массиве
{
    int[] SummArray = new int[rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Summ = Summ + array[i, j];
        }
        SummArray[i] = Summ;
    }
    return SummArray;
}


void PrintArray(int[,] array)       // Вывод массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

void PrintArrayOne(int[] array)       // Вывод одномерного массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("введите количество столбцов > ");
int[,] myArray = GenerateArray(rows, columns, 1, 9);
PrintArray(myArray);
System.Console.WriteLine();

int[] myArray2 = SumRows(myArray, rows);
PrintArrayOne(myArray2);

System.Console.WriteLine($"Минимальная сумма элементов в строке {FindMax(myArray2) + 1}");
