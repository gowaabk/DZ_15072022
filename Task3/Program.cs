/* Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */


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

int[,] MultMatrix(int[,] array1, int[,] array2)           //функция поиска сумм строк в массиве
{
    int[,] MultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                MultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    return MultArray;
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


int rows1 = Prompt("Введите количество строк Матрицы 1 > ");
int columns1 = Prompt("введите количество Матирицы 1 > ");
int rows2 = Prompt("Введите количество строк Матрицы 2 > ");
int columns2 = Prompt("введите количество Матирицы 2 > ");
if (rows1 == columns2)
{
    int[,] myArray1 = GenerateArray(rows1, columns1, 1, 3);
    int[,] myArray2 = GenerateArray(rows2, columns2, 1, 3);
    PrintArray(myArray1);
    System.Console.WriteLine();
    PrintArray(myArray2);
    System.Console.WriteLine();

    int[,] myArray3 = MultMatrix(myArray1, myArray2);
    PrintArray(myArray3);
}
else System.Console.WriteLine("Матрицы нельзя перемножить");
