/* Задача 1: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 */

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

int[,] SortRows(int[,] array)           //функция cортировки строк массива
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
    return array;
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



int rows = Prompt("Введите количество строк > ");
int columns = Prompt("введите количество столбцов > ");
int[,] myArray = GenerateArray(rows, columns, 1, 9);
PrintArray(myArray);
System.Console.WriteLine();

int[,] myArray2 = SortRows(myArray);
PrintArray(myArray2);
